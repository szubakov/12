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
    public class ParameterValueController : Controller
    {
        private PraktiContext _context;

        public ParameterValueController(PraktiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var param = await _context.ParameterValues
                .Include(p => p.Parameter)
                .ToListAsync();

            return View(param);
        }

        [HttpGet]
        public IActionResult Delete(int id) =>
            View(_context.ParameterValues.FirstOrDefault(x => x.IdPValue == id));


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var par = _context.ParameterValues.FirstOrDefault(x => x.IdPValue == id);



            if (par != null)
            {

                _context.ParameterValues.Remove(par);


                _context.SaveChanges();
            }
            else
            {
                _context.ParameterValues.Remove(par);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "ParameterValue");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        { 
             var model = _context.ParameterValues.FirstOrDefault(x => x.IdPValue == id);
            SetSelectLists(ref model);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ParameterValue model)
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
            ParameterValue model = new();
            SetSelectLists(ref model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ParameterValue model)
        {

            _context.ParameterValues.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");



        }
        private void SetSelectLists(ref ParameterValue model)
        {
            model.IdParamNavigations = new SelectList(
                 _context.Parameters.ToList(), "ParameterId", "Name", model.ParameterId);

        }
    }
}

