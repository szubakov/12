using BFStabilityEvaluation.Models;
using BFStabilityEvaluation.Models.Enums;
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
            var vm = new HomeViewModel
            {
                StabilitySigns = _context.StabilitySigns.ToList()     
            };

            if(!vm.StabilitySigns.Any(x => x.StabSignId == id))
            {
                vm.CurrentSignId = vm.StabilitySigns.FirstOrDefault().StabSignId;
            }
            else
            {
                vm.CurrentSignId = id;
            }

            vm.StabilitySignKriteriums = _context.StabilitySignKriteria
                .Include(d => d.Parameter)
                .ThenInclude(d => d.ParameterValues)
                .Where(d => d.Parameter.ParameterValues.Any(s => s.Period == AsuPeriod.Day && s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                .ToList();


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
