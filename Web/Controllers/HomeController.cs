using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public HomeController()
            : base()
        {
        }

        public ActionResult Index()
        {
            ViewBag.ShowSearchBox = true;
            ViewBag.Roles = db.Roles.ToList();
            ViewBag.Users = db.Users.ToList();
            ViewBag.RoleAsManager = db.Roles.Where(r => r.Name.Contains("Quản lí")).First();
            ViewBag.AdminLogs = db.Logs.Where(l => l.User.Role.Id == 1).ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
