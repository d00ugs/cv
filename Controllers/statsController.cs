using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class statsController : Controller
    {
        static Dictionary<string, int> stats = new Dictionary<string, int>()
        {
            ["degree"] = 1,
            ["years"] = 20,
            ["sectors"] = 3,
        };

        // GET api/stats/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            int value;
            if (!stats.TryGetValue(id, out value))
            {
                return NotFound();
            }

            return Json(value);
        }

        // GET api/stats
        [HttpGet]
        public IActionResult Get()
        {
            return Json(stats);
        }
    }
}
