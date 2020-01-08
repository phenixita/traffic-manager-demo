using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegionAwareApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiagController : ControllerBase
    {
        // GET: api/Diag
        [HttpGet]
        public ActionResult<string> Get()
        {
            var diagConfig = Environment.GetEnvironmentVariable("DIAG") ?? "OK";

            if (diagConfig.Equals("KO",StringComparison.InvariantCultureIgnoreCase))
            {
                return new StatusCodeResult(503);
            }

            return "Diag OK";
        }
    }
}
