using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegionAwareApp.Models;

namespace RegionAwareApp.Controllers
{
    [Authorize]

    public class TopSecretController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TopSecretController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
         
        public IActionResult Index()
        {
            return View();
        }
    }
}