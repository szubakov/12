using BFStabilityEvaluation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class StabilitySignKriteriumController : Controller
    {
        private PraktiContext _context;

        public StabilitySignKriteriumController(PraktiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var param = await _context.StabilitySignKriteria
                .Include(p => p.IdParamNavigation)
                .ToListAsync();

            var krit = await _context.StabilitySignKriteria
                 .Include(p => p.IdstabPokazNavigation)
                 .ToListAsync();
            

            return View(param);
        }
        [HttpGet]
        public IActionResult Delete(int id) =>
            View(_context.StabilitySignKriteria.FirstOrDefault(x => x.Id == id));

        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var par = _context.StabilitySignKriteria.FirstOrDefault(x => x.Id == id);



            if (par != null)
            {

                _context.StabilitySignKriteria.Remove(par);


                _context.SaveChanges();
            }
            else
            {
                _context.StabilitySignKriteria.Remove(par);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "StabilitySignKriterium");

        }
    }
}
