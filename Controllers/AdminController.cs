using System.Linq;
using System.Web.Mvc;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class AdminController : Controller
    {
        private PortfolioDBContext db = new PortfolioDBContext();

        public ActionResult Index()
        {
            if (Session["Admin"] == null)
                return RedirectToAction("Login");

            var projects = db.Projects.ToList();
            return View(projects);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "password123")
            {
                Session["Admin"] = true;
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Invalid credentials";
            return View();
        }

        public ActionResult Logout()
        {
            Session["Admin"] = null;
            return RedirectToAction("Login");
        }
    }
}
