using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    public class LKController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
