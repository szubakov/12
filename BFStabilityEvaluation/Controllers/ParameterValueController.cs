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
                .Include(p => p.IdParamNavigation)
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
        public IActionResult Edit(int id) =>
                  View(_context.ParameterValues.FirstOrDefault(x => x.IdPValue == id));

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
        private void SetSelectLists(ref ParameterValue model)
        {
            model.IdParamNavigations = new SelectList(
                    Parameters<List<Parameter>>(
                        _context.ParameterValues.Where(x => x.IdPValue ==)).ToList()), "IDpara", "Name", model.IdParam);
           
        }
    }
}

