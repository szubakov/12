using BFStabilityEvaluation.Models;
using BFStabilityEvaluation.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class ParameterController : Controller
    {
        private PraktiContext _context;

        public ParameterController(PraktiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var param = await _context.Parameters.ToListAsync();

            return View(param);
        }

        [HttpGet]
        public IActionResult Delete(int id) =>
            View(_context.Parameters.FirstOrDefault(x => x.ParameterId == id));

  
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
           
            var par = _context.Parameters.FirstOrDefault(x => x.ParameterId == id);
           
            

                if (par != null)
                {
                   
                    _context.Parameters.Remove(par);
                    

                    _context.SaveChanges();
                }
                else
                {
                    _context.Parameters.Remove(par);
                    _context.SaveChanges();
                }
            

            return RedirectToAction("Index", "Parameter");

        }
        [HttpGet]
        public IActionResult Edit(int id) =>
                   View(_context.Parameters.FirstOrDefault(x => x.ParameterId == id));

        [HttpPost]
        public IActionResult Edit(Parameter model)
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
        public IActionResult Create(Parameter model)
        {
           
                _context.Parameters.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            

          
        }
    }



}

