using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sihotel.Controllers.Suites
{
    public class CasalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
