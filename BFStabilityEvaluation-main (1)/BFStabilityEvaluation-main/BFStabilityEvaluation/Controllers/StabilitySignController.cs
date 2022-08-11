using BFStabilityEvaluation.Models;
using BFStabilityEvaluation.Models.Entities;
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
            var param = await _context.Indicators
                .Include(p => p.StabilitySignKriteria)
                .ToListAsync();

            return View(param);
        }
        [HttpGet]
        public IActionResult Delete(int id) =>
            View(_context.Indicators.FirstOrDefault(x => x.IndicatorId == id));


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var par = _context.Indicators.FirstOrDefault(x => x.IndicatorId == id);



            if (par != null)
            {

                _context.Indicators.Remove(par);


                _context.SaveChanges();
            }
            else
            {
                _context.Indicators.Remove(par);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "StabilitySign");

        }
        [HttpGet]
        public IActionResult Edit(int id) =>
                   View(_context.Indicators.FirstOrDefault(x => x.IndicatorId == id));

        [HttpPost]
        public IActionResult Edit(Indicator model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Indicator model)
        {

            _context.Indicators.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

