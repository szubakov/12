using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BFStabilityEvaluation.Models;
using Microsoft.EntityFrameworkCore;

namespace BFStabilityEvaluation.Controllers
{
    public class RandomGeneratorController : Controller
    {
        private PraktiContext _context;
        public RandomGeneratorController(PraktiContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
