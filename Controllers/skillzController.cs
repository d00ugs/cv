using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class skillsController : Controller
    {
        class skill
        {
            public string title {get; set;}
            public string description {get; set;} = "";
            public string icon { get; set; } = "";
            public string icon_colour { get; set; } = "";
        }

        List<skill> skills = new List<skill> {
            new skill() { title = "Software Development", icon="fa-heart-o", icon_colour="#b51d2a", description=@"Software is my background. I started programming when I was very young and haven’t stopped. I’ve worked with Realtime hardware, Mobile devices, Desktop PCs, Web applications, Databases and most recently developing for the ‘cloud’. During all of this change I’ve tackled UI development, device driver tweaks, database design, framework implementation and, put simply, just done coding."},
            new skill() { title = "Cyber Security", icon="fa-barcode", icon_colour="#151D2A", description=@"Penetration testing, Web application security analysis, Network setup and Firewall configuration,  How to Cloud securely, these are the things that I get asked about. This is currently an area where there is more and more commercial interest, with organisations needing to have increased knowledge, understanding and process to prevent data abuse."},
            new skill() { title = "Project Management", icon="fa-briefcase", icon_colour="#855D2A", description=@"Project management is an all consuming thing. There is never a quiet moment and always something that can be done to improve. I’ve revelled in the intensity and thoroughly enjoy my seeing things come together and complete."},
            new skill() { title = "Line Management", icon="fa-compass", icon_colour="#45ADEA", description=@"Line management is a whole other thing, supporting and motivating to get the most out of people is such a skill. Everyone knows when they’ve had a good boss, I would love to be one of ‘those guys’."},
            new skill() { title = "Business Analysis", icon="fa-windows", icon_colour="#a5aDaA", description=@"I actually quite enjoy the tensions produced during analysis, in trying to marry business need, available (usually old) technology and those all important timescales. This is by far the most challenging thing I do, every engagement is different, there is always a curve ball and the end picture is never as imagined."},
            new skill() { title = "Consulting", icon="fa-tripadvisor", icon_colour="#e51DeA", description=@"Before actually working as a consultant myself, I’d worked with consultants, hired consultants and run projects based on their advice, but it has only been the actual doing of the role that has led to understanding it. To be able to take a situation and all the years of knowledge and experience and distil this into an action plan, to be able to offer some form of tangible value add in a world of greys, that {I believe} is the skill of consulting."},
        };

        // GET api/portfolio
        [HttpGet]
        public IActionResult Get()
        {
            return Json(skills);
        }
    }
}
