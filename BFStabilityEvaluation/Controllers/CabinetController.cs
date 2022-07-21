using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFStabilityEvaluation.Controllers
{
    [Authorize]
    public class CabinetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult OpenAccess()
        {
            return View();
        }
    }

}
