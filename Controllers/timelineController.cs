using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class timelineController : Controller
    {
        class timeline
        {
            public string title {get; set;}
            public string subtitle {get; set;} = "";
            public int start_year { get; set; } = 0;
            public int end_year { get; set; } = 0;
        }
        List<timeline> experience = new List<timeline> 
        {
           new timeline() {title = "Consultant", subtitle = "Quorum Network Resources Limited", start_year = 2014, end_year = 0},
           new timeline() {title = "Section Manager", subtitle = "Petroleum Geo-Services", start_year = 2008, end_year = 2014},
           new timeline() {title = "Team Leader", subtitle = "Picsel", start_year = 2004, end_year = 2008},
           new timeline() {title = "Software Support Engineer", subtitle = "Artesyn Communication Products", start_year = 2000, end_year = 2004},
           new timeline() {title = "Software Engineer", subtitle = "Agilent Technologies", start_year = 1997, end_year = 2000},
        };

        // GET api/timeline
        [HttpGet]
        public IActionResult Get()
        {
            return Json(experience);
        }
    }
}
