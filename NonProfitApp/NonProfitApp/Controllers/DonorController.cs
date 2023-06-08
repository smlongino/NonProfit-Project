using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NonProfitApp.Data;
using NonProfitApp.Models;
using NonProfitApp.ViewModels;
using System.Collections.Generic;

namespace NonProfitApp.Controllers
{
    public class DonorController : Controller
    {
        NonprofitDbContext _context;
        public DonorController(NonprofitDbContext context)
        {
            _context = context;
        }
        // GET: DonorController
        public IActionResult Index(string search)
        {
            IEnumerable<Donor> donors = _context.Donors;

            if (!String.IsNullOrEmpty(search))
            {
                IEnumerable<Donor> filteredDonors = donors.Where(d => d.LastName.ToLower().Contains(search.ToLower()) || d.FirstName.ToLower().Contains(search.ToLower()));
                return View(filteredDonors);
            }
            donors = donors.OrderBy(donor => donor.LastName);
            return View(donors.Where(x => x.Active));
        }

        // GET: DonorController/Details/5
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Donor donor = _context.Donors.SingleOrDefault(d => d.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }
            return View(donor);
        }

        // GET: DonorController/Create
        [HttpGet]
        public IActionResult Create()
        {
            DonorCreateVM donorVM = new DonorCreateVM
            {

            };
            return View(donorVM);
        }

        // POST: DonorController/Create
        [HttpPost]
        public IActionResult Create(DonorCreateVM donorVM)
        {
            if (!ModelState.IsValid)
            {
                return View(donorVM);
            }
            Donor donor = new Donor
            {
                Company = donorVM.Company,
                FirstName = donorVM.FirstName,
                LastName = donorVM.LastName,
                Phone = donorVM.Phone,
                Email = donorVM.Email,
                StreetAddress = donorVM.StreetAddress,
                City = donorVM.City,
                State = donorVM.State,
                Zip = donorVM.Zip,
                Active = donorVM.Active,
                ImageLocation = donorVM.ImageLocation
            };
            _context.Donors.Add(donor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: DonorController/Edit/5
        public IActionResult Edit(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            Donor donor = _context.Donors.SingleOrDefault(x => x.DonorId == id);
            if(donor == null)
            {
                return NotFound();
            }
            return View(donor);
        }

        // POST: DonorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Donor donor)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(donor);
            //}
            _context.Donors.Update(donor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: DonorController/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Donor d = _context.Donors.SingleOrDefault(x => x.DonorId == id);
            if (d == null)
            {
                return NotFound();
            }
            return View(d);
        }

        // POST: DonorController/Delete/5
        [HttpPost]
        public IActionResult Delete(Donor donor)
        {
            if(donor.DonorId == 0)
            {
                return NotFound();
            }
            Donor d = _context.Donors.SingleOrDefault(x => x.DonorId==donor.DonorId);
            if(d == null)
            {
                return NotFound();
            }
            d.Active = false;
            _context.Donors.Update(d);
            _context.SaveChanges();
            return View(d);
        }
    }
    }
