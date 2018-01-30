using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cv.Controllers
{
    [Route("api/[controller]")]
    public class cvController : Controller
    {
        // GET api/cv/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
             Dictionary<string, string> contents = new Dictionary<string, string>() 
             {
                ["overview"] = @"I have a strong enthusiasm for technology, I am passionate about seeing the right tools being used for the right job. My career has often involved fighting the good fight and persuading that change is the right course. Not that crazy change just because what we have isn’t working change, but the measured, controlled, understood change – the change where everyone is happy, not just the IT guy that got the new thing.
                
By contrast, at home there are two distinct setups: the it/IT just works {TV, wifi, family ipads and computers}; and the toy-box of half finished RasberryPI projects, Bluetooth code and web-apps.
                
I'm 'into computers', cloud, tablet, coding, building. I like mobile, Internet of Things, Virtual Reality, Augmented Reality. As a proper old skool geek I am into all of the Linux, Apple and Microsoft.",
                ["quote"] = @"On two occasions I have been asked, ‘Pray, Mr. Babbage, if you put into the machine wrong figures, will the right answers come out?’ I am not able rightly to apprehend the kind of confusion of ideas that could provoke such a question.",
                ["quote_author"] = @"Charles Babbage",
                ["born"] = @"1975",
                ["workas"] = @"Consultant",
                ["email"] = @"e@dou",
                ["email_tld"] = @"gs",
                ["project_intro"] = @"Some of the large number of different projects I’ve been lucky enough to work on over the years...",
             };

            string value = "";
            if (!contents.TryGetValue(id, out value))
            {
                return NotFound();
            }


            return Json(value);
        }
    }
}
