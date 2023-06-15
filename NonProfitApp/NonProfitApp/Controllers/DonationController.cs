using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonProfitApp.Data;
using NonProfitApp.Models;
using NonProfitApp.ViewModels;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipelines;
using System.Security.Policy;

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
            IEnumerable<Donation> donations = _context.Donations.Include(x => x.Channel).Include(x => x.OrgProgram).Include(x => x.Fundraiser).Include(x => x.Donor);
            donations = donations.OrderBy(donation => donation.DonationDate);

            return View(donations);
            
        }
        public IActionResult DonationsByDonor(int donorId)
        {
            IEnumerable<Donation> donationsByDonor = _context.Donations.Where(d => d.DonorId == donorId).Select(d => new Donation
            {
                DonationId = d.DonationId,
                DonationAmount = d.DonationAmount,
                DonationDate = d.DonationDate,
                Donor = d.Donor,
                OrgProgram = d.OrgProgram,
                Fundraiser = d.Fundraiser,
                Channel = d.Channel

            });
            return View(donationsByDonor);

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
            donation.Donor = _context.Donors.SingleOrDefault(d => d.DonorId == donation.DonorId);
            donation.OrgProgram = _context.OrgPrograms.SingleOrDefault(p => p.ProgramId == donation.ProgramId);
            donation.Fundraiser = _context.Fundraisers.SingleOrDefault(f => f.FundraiserId == donation.FundraiserId);
            return View(donation);
        }
        [HttpGet]
        public IActionResult CreatefromDonor(int donorId)
        {
            if (donorId == 0)
            {
                return NotFound();
            }
            Donor donor = _context.Donors.SingleOrDefault(d => d.DonorId == donorId);
            if (donor == null)
            {
                return NotFound();
            }
            //create select list
            IEnumerable<SelectListItem> donorList = _context.Donors.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.FirstName + " " + x.LastName,
                Value = x.DonorId.ToString()
            });
            IEnumerable<SelectListItem> channelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.ChannelType,
                Value = x.ChannelId.ToString()
            });
            IEnumerable<SelectListItem> programList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ProgramId.ToString()
            });
            IEnumerable<SelectListItem> fundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.FundraiserName,
                Value = x.FundraiserId.ToString()
            });

            DonationCreateVM donationCreateVM = new DonationCreateVM
            {
                DonorId = donor.DonorId,
                Donor = donor,
                ChannelList = channelList,
                ProgramList = programList,
                FundraiserList = fundraiserList,
                DonorList = donorList

            };
            return View(donationCreateVM);
        }
        [HttpPost]
        public IActionResult CreatefromDonor(DonationCreateVM donationCreateVM)
        {
            if (!ModelState.IsValid)
            {
                donationCreateVM.ChannelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.ChannelType,
                    Value = x.ChannelId.ToString(),
                });
                donationCreateVM.ProgramList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProgramId.ToString(),
                });
                donationCreateVM.FundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.FundraiserName,
                    Value = x.FundraiserId.ToString(),
                });
                donationCreateVM.DonorList = _context.Donors.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.FirstName + " " + x.LastName,
                    Value = x.DonorId.ToString(),
                });

                return View(donationCreateVM);
            }
            Donation donation = new Donation
            {
                DonationAmount = donationCreateVM.DonationAmount,
                DonationDate = donationCreateVM.DonationDate,
                ChannelId = donationCreateVM.ChannelId,
                ProgramId = donationCreateVM.ProgramId,
                FundraiserId = donationCreateVM.FundraiserId,
                DonorId = donationCreateVM.DonorId

            };
            _context.Donations.Add(donation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            //create select list
            IEnumerable<SelectListItem> donorList = _context.Donors.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.FirstName + " " + x.LastName, 
                Value = x.DonorId.ToString()
            });
            IEnumerable<SelectListItem> channelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.ChannelType,
                Value = x.ChannelId.ToString()
            });
            IEnumerable<SelectListItem> programList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ProgramId.ToString()
            });
            IEnumerable<SelectListItem> fundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.FundraiserName,
                Value = x.FundraiserId.ToString()
            });

            DonationCreateVM donationCreateVM = new DonationCreateVM
            {
                ChannelList = channelList,
                ProgramList = programList,
                FundraiserList = fundraiserList,
                DonorList = donorList

            };
            return View(donationCreateVM);
        }

        [HttpPost]
        public IActionResult Create(DonationCreateVM donationCreateVM)
        {
            if (!ModelState.IsValid)
            {
                donationCreateVM.ChannelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.ChannelType,
                    Value = x.ChannelId.ToString(),
                });
                donationCreateVM.ProgramList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProgramId.ToString(),
                });
                donationCreateVM.FundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.FundraiserName,
                    Value = x.FundraiserId.ToString(),
                });
                donationCreateVM.DonorList = _context.Donors.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.FirstName + " " + x.LastName,
                    Value = x.DonorId.ToString(),
                });

                return View(donationCreateVM);
            }
            Donation donation = new Donation
            {
                DonationAmount = donationCreateVM.DonationAmount,
                DonationDate = donationCreateVM.DonationDate,
                ChannelId = donationCreateVM.ChannelId,
                ProgramId = donationCreateVM.ProgramId,
                FundraiserId = donationCreateVM.FundraiserId,
                DonorId = donationCreateVM.DonorId

            };
            _context.Donations.Add(donation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int donationId)
        {
            if (donationId == 0)
            {
                return NotFound();
            }
            Donation donation = _context.Donations.SingleOrDefault(x => x.DonationId == donationId);
            if (donation is null)
            {
                return NotFound();
            }
            Donor donor = _context.Donors.SingleOrDefault(d => d.DonorId == donation.DonorId);
            donation.Donor = donor;

            //create select list
            IEnumerable<SelectListItem> channelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.ChannelType,
                Value = x.ChannelId.ToString(),
                Selected = (donation.ChannelId == x.ChannelId)
            });
            IEnumerable<SelectListItem> programList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.ProgramId.ToString(),
                Selected = (donation.ProgramId == x.ProgramId)
            });
            IEnumerable<SelectListItem> fundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
            {
                Text = x.FundraiserName,
                Value = x.FundraiserId.ToString(),
                Selected = (donation.FundraiserId == x.FundraiserId)
            });

            DonationEditVM donationEditVM = new DonationEditVM
            {
                ChannelList = channelList,
                ProgramList = programList,
                FundraiserList = fundraiserList,

            };
            return View(donationEditVM);
        }
        [HttpPost]
        public IActionResult Edit(DonationEditVM donationEditVM)
        {

            if (!ModelState.IsValid)
            {
                donationEditVM.ChannelList = _context.Channels.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.ChannelType,
                    Value = x.ChannelId.ToString(),
                });
                donationEditVM.ProgramList = _context.OrgPrograms.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProgramId.ToString(),
                });
                donationEditVM.FundraiserList = _context.Fundraisers.Where(x => x.Active).Select(x => new SelectListItem
                {
                    Text = x.FundraiserName,
                    Value = x.FundraiserId.ToString(),
                });

                return View(donationEditVM);
            }
            Donation donation = _context.Donations.SingleOrDefault(d => d.DonationId == donationEditVM.DonationId);
            donation.ChannelId = donationEditVM?.ChannelId;
            donation.ProgramId = donationEditVM?.ProgramId;
            donation.FundraiserId = donationEditVM?.FundraiserId;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Donation donation = _context.Donations.SingleOrDefault(p => p.DonationId == id);
            if (donation == null)
            {
                return NotFound();
            }
            return View(donation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Donation donation)
        {
            _context.Donations.Remove(donation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    
}
}

