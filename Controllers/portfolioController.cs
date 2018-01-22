using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class portfolioController : Controller
    {
        class portfolio
        {
            public string title {get; set;}
            public string subtitle {get; set;}
            public string description {get; set;}
        }

        Dictionary<string, portfolio> fullPortfolio = new Dictionary<string, portfolio>() 
        {
            ["em_patent"] = new portfolio() {title = @"Electromagnetic surveying", subtitle = @"Patent", description = @"I have one patent to my name. https://www.google.com/patents/US20130221969

    ABSTRACT
    Disclosed are methods and apparatus for adaptive source electromagnetic (EM) surveying. In accordance with one embodiment, a source waveform signal is generated, and an outgoing EM signal which is based on the source waveform signal is transmitted using an antenna. A responsive electromagnetic signal is detected using at least one electromagnetic sensor, and a receiver waveform signal based on the responsive electromagnetic signal is obtained. A feedback control signal which depends on at least one input signal is determined. Based on the feedback control signal, the source waveform signal is adapted. Other embodiments, aspects, and features are also disclosed."},
            ["security_audit"] = new portfolio() {title = @"Security audit"},
        };

        // GET api/portfolio/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            portfolio value;
            if (!fullPortfolio.TryGetValue(id, out value))
            {
                return NotFound();
            }

            return Ok(value.description);
        }

        // GET api/portfolio
        [HttpGet]
        public IActionResult Get()
        {
            return Json(fullPortfolio.Keys.ToList());
        }
    }
}
