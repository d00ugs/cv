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
            public string description {get; set;} = "";
            public string category { get; set; } = "";
            public string duration { get; set; } = "";
            public string imgUrl { get; set; } = "";
        }
        static Dictionary<string, string> categories = new Dictionary<string, string>()
        {
            ["patent"] = @"Patent",
            ["consultant"] = @"Consultant",
            ["software"] = @"Software",
            ["management"] = @"Management",
        };

        Dictionary<string, portfolio> fullPortfolio = new Dictionary<string, portfolio>() 
        {
            ["em_patent"] = new portfolio() {title = @"Electromagnetic surveying", category = "patent", imgUrl = "US-PatentTrademarkOffice.png", description = @"I have one patent to my name. https://www.google.com/patents/US20130221969

    ABSTRACT
    Disclosed are methods and apparatus for adaptive source electromagnetic (EM) surveying. In accordance with one embodiment, a source waveform signal is generated, and an outgoing EM signal which is based on the source waveform signal is transmitted using an antenna. A responsive electromagnetic signal is detected using at least one electromagnetic sensor, and a receiver waveform signal based on the responsive electromagnetic signal is obtained. A feedback control signal which depends on at least one input signal is determined. Based on the feedback control signal, the source waveform signal is adapted. Other embodiments, aspects, and features are also disclosed."},
            ["security_audit"] = new portfolio() {title = @"Security audit", category ="consultant", duration="2 month engagement", description=@"The client commissioned a security audit of one of the key technologies deploy supporting it’s banking business.

During this project I identified the specifics of the full system deployed and defined the complete requirements for a relevant security audit. Subsequently I conduct the technical audit using a variety of security tools and methods. The results of this process were analysed and summarised in a security report.  Finally, this information was also presented to and discussed with client management."},
            ["process_improvement"] = new portfolio() {title = @"Business Process Improvement", category = "consultant", imgUrl = "lloyds-banking-group-logo-new.jpg", duration = "6 month involvement", description = @"Focusing on improvement, this contract involved working with internal financial processes. Concentrating on simplifying in order to maintain accuracy in a dynamic evolving business area. During this work I carried out process analysis, improvement recommendation, training, improvement-build and solution deployment."},
            ["bank_application"] = new portfolio() {title = @"Custom Bank Application", category = "consultant", imgUrl = "hampden-co-logo-1.png", duration = "3 month involvement", description = @"The client commissioned a review of their B2B solution, this review and report included recommendations for improvement. My involvement then moved on to actioning the priority recommendations and delivering an updated solution. This involved a business case review and technical audit as well as the build and role out of new B2B system."},
            ["signalling_advisor"] = new portfolio() {title = @"Signaling Advisor", category = "software", imgUrl = "calltrace.png", duration = "3 years on project", description = @"I produced C++ software for the company’s custom hardware in one of their SS7 telecoms test group.  My entire time with Agilent was devoted to a single product, working in three different areas. Agilent has a good record with product quality and follows ISO standards, this combined with a need for five 9s uptime in the telecom industry introduced me to many good engineering practices."},
            ["discovery"] = new portfolio() {title = @"Server Discovery", category = "consultant", duration = "10 month involvement", description = @"This was a particularly broad project involving a team with many and varied skills. My role was that of Business Analyst / Management Information Developer, working to both collect and collate information covering the some of the technologies in production as well as defining the consolidated information reports for these system hardware estates. Functions delivered include:

Production of Management Information: Delivered to regular and ad-hoc requests for Management Information. Defining and agreeing the full range of metrics, supporting performance management and business improvement activities.

Design of Data Measurements: Designed relevant measurements that utilised business-related data to create Management Information to allow performance assessment and strategic planning for ongoing improvement programs.

Business Intelligence: Provide analysis and commentary of Management Information reports to deliver business pertinent conclusions, essentially providing Management with increased knowledge in key technology areas, providing recommendations when required."},
            ["sctp"] = new portfolio() {title=@"SCTP", category = "software", imgUrl = "SCTP-Multihoming.png", duration = "2 year project", description = @"I developed part of a communication protocol implementation (SCTP) for a number of different operating systems."},
            ["picsel"] = new portfolio() {title = @"Picsel Browser", category = "management", imgUrl = "pb.jpg", duration = "3 years covering the two projects", description = @"Relying on my background in software, I was responsible for a team of 10 software engineers within a larger software department. I completed two separate projects during my time with Picsel.

1yr project

The first was a development project, “YouTube on your phone”, in the pre-smartphone era.

2yr project

The second was a project to support “Widgets on mobile”, again before the whole ‘apps’ technology was commonly available."},
            ["pgs_em"] = new portfolio() {title = @"Towed Streamer ElectroMagnetics", category = "management", imgUrl = "pgsem.jpg", duration = "5 year running research and development projects", description = @"PGS operates in the Oil & Gas industry as an offshore exploration service provider. My role, along with 4 others (as Section Managers within PGS’ Geophysics and Engineering department) was to deliver a unique new technology for the company’s business units. This was a 5-year programme with a total budget of $50M over the period.

I defined and ran several agile projects during the 5 years covering many technical disciplines: Systems, Electronic, Mechanical, Power, Software and Firmware engineering as well as the support functions for Quality, Test and Procurement. These projects ranged in size from individual assignments to project teams of up to 10 staff with CAPEX of $2M.  They covered everything from concept work to commercial deliverables and had a heavy focus on health and safety."},
            ["consulting"] = new portfolio() {title = @"Consulting", category = "consulting", imgUrl="Quorum-Logo.jpg", description = @"Quorum are an IT consultancy focusing on high end and bespoke IT consultancy services. They are a Microsoft Gold partner.

Checkout www.qnrl.com"},
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
            return Json(fullPortfolio.ToList());
        }
    }
}
