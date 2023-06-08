using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonProfitApp.Data;
using NonProfitApp.Models;
using NonProfitApp.ViewModels;

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
            //Use Include() if you have a collection
            IEnumerable<Donation> donations = _context.Donations.Include(x => x.Channel).Include(x => x.OrgProgram).Include(x => x.Fundraiser);
            donations = donations.OrderBy(donation => donation.DonationDate);
            return View(donations);
        }

        // GET: DonationController/Details/5
        public IActionResult Details(int id)
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
            //Can't use Include() for a single instance, must do it by hand
            //Pull the Channel from the donation and pass it to the view using the Channel nav prop
            donation.Channel = _context.Channels.SingleOrDefault(c => c.ChannelId == donation.ChannelId);
            return View(donation);
        }

        // GET: DonationController/Create
        //take a donorId as a parameter to create a donation
        public IActionResult Create(int donorId)
        {
            if(donorId == 0)
            {
                return NotFound();
            }
            Donor donor = _context.Donors.SingleOrDefault(x => x.DonorId == donorId);
            if (donor == null)
            {
                return NotFound();
            }

            //create select list
            IEnumerable<SelectListItem> channelList = _context.Channels.Select(x => new SelectListItem
            {
                Text = x.ChannelType,
                Value = x.ChannelId.ToString(),
            });
            IEnumerable<SelectListItem> programList = _context.OrgPrograms.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ProgramId.ToString(),
            });
            IEnumerable<SelectListItem> fundraiserList = _context.Fundraisers.Select(x => new SelectListItem
            {
                Text = x.FundraiserName,
                Value = x.FundraiserId.ToString(),
            });

            DonationCreateVM donationCreateVM = new DonationCreateVM
            {
                ChannelList = channelList,
                ProgramList = programList,
                FundraiserList = fundraiserList,
                DonorId = donor.DonorId,
                Donor = donor

            };
            return View(donationCreateVM);
        }
        [HttpPost]
        public IActionResult Create(DonationCreateVM donationCreateVM)
        {
            if(!ModelState.IsValid)
            {
                donationCreateVM.ChannelList = _context.Channels.Select(x => new SelectListItem
                {
                    Text = x.ChannelType,
                    Value = x.ChannelId.ToString(),
                });
                donationCreateVM.ProgramList = _context.OrgPrograms.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProgramId.ToString(),
                });
                donationCreateVM.FundraiserList = _context.Fundraisers.Select(x => new SelectListItem
                {
                    Text = x.FundraiserName,
                    Value = x.FundraiserId.ToString(),
                });

                return View(donationCreateVM);
            }
            Donation donation = new Donation
            {
                DonationAmount = donationCreateVM.DonationAmount,
                DonationDate = donationCreateVM.DonationDate,
                ChannelId = donationCreateVM.ChannelId,
                ProgramId = donationCreateVM.ProgramId,
                FundraiserId = donationCreateVM.FundraiserId

            };
            _context.Donations.Add(donation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

