using BFStabilityEvaluation.Extension;
using BFStabilityEvaluation.Models;
using BFStabilityEvaluation.Models.Enums;
using BFStabilityEvaluation.Models.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PraktiContext _context;

        public HomeController(ILogger<HomeController> logger, PraktiContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var indicators = _context.Indicators.OrderBy(x => x.Order).ToList();

            var simpleCriterions = _context.SimpleCriterions
                .Include(d => d.Parameter)
                .ThenInclude(d => d.ParameterValues)
                .Where(d => d.Parameter.ParameterValues.Any(s => s.Period == AsuPeriod.Day && s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                .ToList();

            var complexCriterions = _context.ComplexCriterions.ToList();

            var vm = new HomeViewModel();

            if(!indicators.Any(x => x.IndicatorId == id))
            {
                vm.CurrentIndicatorId = indicators.FirstOrDefault().IndicatorId;
            }
            else
            {
                vm.CurrentIndicatorId = id;
            }

            // CriterionViewModel List
            foreach (var criterion in simpleCriterions)
            {
                var average = criterion.Parameter.ParameterValues.Select(x => x.Value).Average();
                var stdDev = criterion.Parameter.ParameterValues.Select(x => x.Value).StdDev();

                vm.Criterions.Add(new CriterionViewModel
                {
                    Name = criterion.Parameter?.Name,
                    Unit = criterion.Parameter?.Unit,
                    IndicatorId = criterion.IndicatorId,
                    AcceptableDelta = criterion.AcceptableDelta,
                    Rang = criterion.Rang,
                    AverageValue = average,
                    StdDevValue = stdDev
                });
            }

            // IndicatorViewModel List
            foreach (var indicator in indicators)
            {
                var currentComplexCriterions = complexCriterions.Where(x => x.СalculatedIndicatorId == indicator.IndicatorId).ToList();
                var currentSimpleCriterions = vm.Criterions.Where(x => x.IndicatorId == indicator.IndicatorId).ToList();

                var value = indicator.Type == IndicatorType.Simple ?
                    StabilityCore.GetStabilitySimpleValue(currentSimpleCriterions) :
                    StabilityCore.GetStabilityComplexValue(currentComplexCriterions, vm.Indicators);

                vm.Indicators.Add(new IndicatorViewModel
                {
                    IndicatorId = indicator.IndicatorId,
                    Name = indicator.Name,
                    Type = indicator.Type,
                    LimitDanger = indicator.LimitDanger,
                    LimitWarning = indicator.LimitWarning,
                    Value = value
                });
            }

            return View(vm);
        }

        public IActionResult Info()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
