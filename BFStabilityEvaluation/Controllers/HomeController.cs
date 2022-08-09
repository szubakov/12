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

     
       
        public IActionResult Index1()
        {

            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))

                .ToList();




            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };



            return View(ivm);
        }


        public IActionResult Index2()
        {
            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))

                .ToList();




            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };



            return View(ivm);
        }
        public IActionResult Index3()
        {
            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                  .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                  .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                  .ToList();
            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };
            return View(ivm);
        }
        public IActionResult Index4()
        {
            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                  .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                  .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                  .ToList();
            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };
            return View(ivm);
        }
        public IActionResult Index5()
        {
            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                 .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                 .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                 .ToList();
            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };
            return View(ivm);
        }
        public IActionResult Index6()
        {
            List<StabilitySignKriterium> compModels = _context.StabilitySignKriteria
                  .Include(d => d.Parameter).ThenInclude(d => d.ParameterValues)
                  .Where(d => d.Parameter.ParameterValues.Any(s => s.TimeStampStart.Day >= DateTime.Now.Day - 30))
                  .ToList();
            HomeViewModel ivm = new() { StabilitySignKriteriums = compModels };
            return View(ivm);
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
