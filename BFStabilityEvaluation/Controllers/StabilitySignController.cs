using BFStabilityEvaluation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class StabilitySignController : Controller
    {
        private PraktiContext _context;

        public StabilitySignController(PraktiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var param = await _context.StabilitySigns
                .Include(p => p.StabilitySignKriteria)
                .ToListAsync();

            return View(param);
        }
        [HttpGet]
        public IActionResult Delete(int id) =>
            View(_context.StabilitySigns.FirstOrDefault(x => x.IdstabPokaz == id));


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var par = _context.StabilitySigns.FirstOrDefault(x => x.IdstabPokaz == id);



            if (par != null)
            {

                _context.StabilitySigns.Remove(par);


                _context.SaveChanges();
            }
            else
            {
                _context.StabilitySigns.Remove(par);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "StabilitySign");

        }
    }
}

