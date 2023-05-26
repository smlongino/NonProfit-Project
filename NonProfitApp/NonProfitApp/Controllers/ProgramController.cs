using Microsoft.AspNetCore.Mvc;
using NonProfitApp.Data;
using NonProfitApp.Models;

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
                return View(programs);
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(OrgProgram program)
            {
                //if (!ModelState.IsValid)
                //{
                //    return View(channel);
                //}
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
                //if(!ModelState.IsValid)
                //{
                //    return View(channel);
                //}
                _context.OrgPrograms.Remove(program);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
