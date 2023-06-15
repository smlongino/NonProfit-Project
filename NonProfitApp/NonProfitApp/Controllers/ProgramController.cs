using Microsoft.AspNetCore.Mvc;
using NonProfitApp.Data;
using NonProfitApp.Models;
using System.Threading.Channels;

namespace NonProfitApp.Controllers
{
     public class ProgramController : Controller
        {
            NonprofitDbContext _context;
            public ProgramController(NonprofitDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                IEnumerable<OrgProgram> programs = _context.OrgPrograms;
                programs = programs.OrderBy(programs => programs.Name);
                return View(programs.Where(x => x.Active));
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(OrgProgram program)
            {
            if (!ModelState.IsValid)
            {
                return View(program);
            }
            if (_context.OrgPrograms.Where(p => p.Active).Any(p => p.Name == program.Name))
            {
                return View(program);
            }
            _context.OrgPrograms.Add(program);
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
                OrgProgram program = _context.OrgPrograms.SingleOrDefault(p => p.ProgramId == id);
                if (program == null)
                {
                    return NotFound();
                }
                return View(program);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Delete(OrgProgram program)
            {
            if(program.ProgramId == 0)
            {
                return NotFound();
            }
            OrgProgram p = _context.OrgPrograms.SingleOrDefault(p => p.ProgramId == program.ProgramId);
            if(p == null)
            {
                return NotFound();
            }
            
            p.Active = false;
            _context.OrgPrograms.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
        }
    }
