using BFStabilityEvaluation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                .Include(p => p.Parameter)
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.StabilitySignKriteria.FirstOrDefault(x => x.Id == id);
            SetSelectLists(ref model);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(StabilitySignKriterium model)
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
            StabilitySignKriterium model = new();
            SetSelectLists(ref model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StabilitySignKriterium model)
        {

            _context.StabilitySignKriteria.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");



        }

        private void SetSelectLists(ref StabilitySignKriterium model)
        {
            model.IdParamNavigations = new SelectList(
                 _context.Parameters.ToList(), "ParameterId", "Name", model.ParameterId);

            model.IdstabPokazNavigations = new SelectList(
                 _context.StabilitySigns.ToList(), "StabSignId", "Name", model.StabSignId);
        }
      
    }
}
