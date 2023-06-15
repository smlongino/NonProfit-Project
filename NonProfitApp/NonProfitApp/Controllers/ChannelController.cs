using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NonProfitApp.Data;
using NonProfitApp.Models;

namespace NonProfitApp.Controllers
{
    public class ChannelController : Controller
    {
        NonprofitDbContext _context;
        public ChannelController(NonprofitDbContext context)
        {
            _context = context;
        }
        // GET: ChannelController
        public IActionResult Index()
        {
            IEnumerable<Channel> channels = _context.Channels;
            channels = channels.OrderBy(channels => channels.ChannelType);
            return View(channels.Where(x => x.Active));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Channel channel)
        {
            if (!ModelState.IsValid)
            {
                return View(channel);
            }
            if (_context.Channels.Where(c => c.Active).Any(c => c.ChannelType == channel.ChannelType))
            {
                return View(channel);
            }

            _context.Channels.Add(channel);
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
            Channel channel = _context.Channels.SingleOrDefault(c => c.ChannelId == id);
            if(channel == null)
            {
                return NotFound();
            }
            return View(channel);
        }

        // POST: ChannelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Channel channel)
        {
            if (channel.ChannelId == 0)
            {
                return NotFound();
            }
            Channel c = _context.Channels.SingleOrDefault(c => c.ChannelId == channel.ChannelId);
            if (c == null)
            {
                return NotFound();
            }
            c.Active = false;
            _context.Channels.Update(c);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
