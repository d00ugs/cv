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
        public string Get(string id)
        {
             Dictionary<string, string> contents = new Dictionary<string, string>() 
             {
                ["overview"] = @"I have a strong enthusiasm for technology, I am passionate about seeing the right tools being used for the right job. My career has often involved fighting the good fight and persuading that change is the right course. Not that crazy change just because what we have isn’t working change, but the measured, controlled, understood change – the change where everyone is happy, not just the IT guy that got the new thing.
                
By contrast, at home there are two distinct setups: the it/IT just works {TV, wifi, family ipads and computers}; and the toy-box of half finished RasberryPI projects, Bluetooth code and web-apps.
                
I'm 'into computers', cloud, tablet, coding, building. I like mobile, Internet of Things, Virtual Reality, Augmented Reality. As a proper old skool geek I am into all of the Linux, Apple and Microsoft.",
             };

            string value;
            if(false == contents.TryGetValue(id, out value))
            {
                value = id;
            }
            return value;
        }

    }
}
