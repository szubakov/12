using BFStabilityEvaluation.Models;
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index1()
        {

            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                .Select(c => new StabilitySignKriterium { Id = c.Id, Name = c.Name })
                .ToList();

            List<ParameterValue> ParMS = _context.ParameterValues
                .Select(c => new ParameterValue { Id = c.Id, Value = c.Value })
                .ToList();

            HomeViewModel ivm = new HomeViewModel { StabilitySignKriteriums = compModels, ParameterValues = ParMS };


            return View(ivm);
        }



        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
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
