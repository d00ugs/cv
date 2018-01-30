using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class categoriesController : Controller
    {
        static Dictionary<string, string> categories = new Dictionary<string, string>()
        {
            ["patent"] = @"Patent",
            ["consultant"] = @"Consultant",
            ["software"] = @"Software",
            ["management"] = @"Management",
        };

        // GET api/categories/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            string value;
            if (!categories.TryGetValue(id, out value))
            {
                return NotFound();
            }

            return Ok(value);
        }

        // GET api/categories
        [HttpGet]
        public IActionResult Get()
        {
            return Json(categories);
        }
    }
}
