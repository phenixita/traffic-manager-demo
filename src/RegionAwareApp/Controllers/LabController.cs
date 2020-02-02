using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RegionAwareApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LabController : Controller
    {
        private readonly ILogger<LabController> _logger;

        public LabController(ILogger<LabController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var labConfig = Environment.GetEnvironmentVariable("LAB_EXPERIMENT") ?? "0";

            if (labConfig.Equals("1", StringComparison.InvariantCultureIgnoreCase))
            {
                return ExperimentalFeature();
            }

            return GoodOldAlg();
        }

        private IActionResult GoodOldAlg()
        {
            return View();
        }

        private IActionResult ExperimentalFeature()
        {
            DateTime now = DateTime.Now;
            while (DateTime.Now < now.AddSeconds(2))
            {

            }
            return View();
        }

        private long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }

    }
}