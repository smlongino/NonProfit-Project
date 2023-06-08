using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NonProfitApp.Data;
using NonProfitApp.Models;

namespace NonProfitApp.Controllers
{

    public class FundraiserController : Controller
    {
        NonprofitDbContext _context;
        public FundraiserController(NonprofitDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Fundraiser> fundraisers = _context.Fundraisers;
            fundraisers = fundraisers.OrderBy(fundraisers => fundraisers.FundraiserName);
            return View(fundraisers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Fundraiser fundraiser)
        {
            if (!ModelState.IsValid)
            {
                return View(fundraiser);
            }
            _context.Fundraisers.Add(fundraiser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Fundraiser fundraiser = _context.Fundraisers.SingleOrDefault(f => f.FundraiserId == id);
            if (fundraiser == null)
            {
                return NotFound();
            }
            return View(fundraiser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Fundraiser fundraiser)
        {
            //if(!ModelState.IsValid)
            //{
            //    return View(fundraiser);
            //}
            _context.Fundraisers.Remove(fundraiser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Fundraiser fundraiser = _context.Fundraisers.SingleOrDefault(f => f.FundraiserId == id);
            if (fundraiser == null)
            {
                return NotFound();
            }
            return View(fundraiser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fundraiser fundraiser)
        {
            //if(!ModelState.IsValid)
            //{
            //    return View(fundraiser);
            //}
            _context.Fundraisers.Update(fundraiser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
