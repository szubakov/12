using Microsoft.AspNetCore.Mvc;
using BFStabilityEvaluation.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BFStabilityEvaluation.Models.RandomGeneratorModels;
using System.Threading.Tasks;
using BFStabilityEvaluation.Models.Enums;

namespace BFStabilityEvaluation.Controllers
{
    public class RandomGeneratorController : Controller
    {
        private PraktiContext _context;

        public RandomGeneratorController(PraktiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var dateEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            var viewModel = new RandomGeneratorViewModel
            {
                DateBeg = dateEnd.AddDays(-7),
                DateEnd = dateEnd,
                Npech = 1
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(RandomGeneratorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var parameters = await _context.Parameters.AsNoTracking().ToListAsync();
                
                foreach (var parameter in parameters)
                {
                    var randomGenerator = new RandomGeneratorModel(parameter, model.Npech, model.DateBeg, model.DateEnd);
                    var paramsValues1 = randomGenerator.GetParameterValues(AsuPeriod.Hour);
                 
                   

                    await FillParameterValues(paramsValues1);
                  

                }
                foreach (var parameter in parameters)
                {
                    var randomGenerator = new RandomGeneratorModel(parameter, model.Npech, model.DateBeg, model.DateEnd);
                   
                    var paramsValues = randomGenerator.GetParameterValues(AsuPeriod.Day);


                    
                    await FillParameterValues(paramsValues);

                }

                foreach (var parameter in parameters)
                {
                    var randomGenerator = new RandomGeneratorModel(parameter, model.Npech, model.DateBeg, model.DateEnd);

                    var paramsValues = randomGenerator.GetParameterValues(AsuPeriod.Smena);



                    await FillParameterValues(paramsValues);

                }

                return RedirectToAction("Index", "ParameterValue");

            

            }

            return View(model);
        }

        private async Task FillParameterValues(List<ParameterValue> parameterValues)
        {
            foreach (var paramValue in parameterValues)
            {
                var existValue = await _context.ParameterValues.AnyAsync(x => x.Npech == paramValue.Npech && x.ParameterId == paramValue.ParameterId && x.TimeStampStart == paramValue.TimeStampStart && x.Period == paramValue.Period);

                if (!existValue)
                {
                    await _context.AddAsync(paramValue);
                }
            }
            

            await _context.SaveChangesAsync();
        }
    }
}
