using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountingSystemProject.DAL;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class ReOrderSafetyEOQController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ReOrderSafetyEOQ
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReOrderSafetyEOQ()
        {
            return View();
        }

    }
}