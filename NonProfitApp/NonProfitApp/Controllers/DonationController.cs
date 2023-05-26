using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NonProfitApp.Data;
using NonProfitApp.Models;

namespace NonProfitApp.Controllers
{
    public class DonationController : Controller
    {
        NonprofitDbContext _context;
        public DonationController(NonprofitDbContext context)
        {
            _context = context;
        }
        // GET: DonationController
        public ActionResult Index()
        {
            IEnumerable<Donation> donations = _context.Donations;
            donations = donations.OrderBy(donation => donation.DonationDate);
            return View(donations);
        }

        // GET: DonationController/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Donation donation = _context.Donations.SingleOrDefault(d => d.DonationId == id);
            if (donation == null)
            {
                return NotFound();
            }
            return View(donation);
        }

        // GET: DonationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
