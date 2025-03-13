using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioDBContext db = new PortfolioDBContext();

        // Index Action - Displays all projects
        public ActionResult Index()
        {
            var projects = db.Projects.ToList() ?? new List<Project>(); // Prevent null reference
            return View(projects);
        }

        // About Action - Displays a brief about the developer and their skills/experience
        public ActionResult About()
        {
            ViewBag.Description = "I am a Full-Stack Developer specializing in ASP.NET MVC, SQL Server, and modern web technologies. I have experience working on both front-end and back-end development, and I am passionate about building scalable, high-performance applications. I enjoy learning new technologies and solving complex problems to improve system performance and user experience.";

            ViewBag.Skills = new List<string>
            {
                "Backend Development: ASP.NET, .NET Core, MVC Framework, SQL Server",
                "Frontend Development: JavaScript, HTML, CSS, UI/UX Design",
                "Databases: SQL Server, MySQL, Microsoft SQL Server",
                "Software Development: Full-Stack, Web Application Development, Performance Optimization"
            };

            ViewBag.Experience = new List<string>
            {
                "Software Developer at Three Star Infotech (Aug 2023 – June 2024): Developed and optimized backend systems, automated business processes, and improved user engagement.",
                "Forts Tourism Website: Created an online tourism platform, optimized performance, and implemented a booking system.",
                "Digital Banking Solution: Engineered a digital banking platform, improving transaction speed and user engagement."
            };

            return View();
        }

        // Projects Action - Displays a list of all projects
        public ActionResult Projects()
        {
            var projects = db.Projects.ToList() ?? new List<Project>(); // Prevent null reference
            return View(projects);
        }

        // Contact Action - Displays the contact form
        public ActionResult Contact()
        {
            return View();
        }

        // Post method for the Contact Action - Saves the message to the database
        [HttpPost]
        public ActionResult Contact(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                db.ContactMessages.Add(message);
                db.SaveChanges();
                ViewBag.Message = "Thank you! I'll get back to you soon.";
            }
            return View();
        }
    }
}
