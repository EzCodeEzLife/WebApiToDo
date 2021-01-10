using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListWeb.Models;

namespace ToDoListWeb.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();
        public ActionResult Index()
        {
            IEnumerable<Task> tasks = db.Tasks;
            ViewBag.Tasks = tasks;
            return View(db.Tasks);
        }
    }
}
