using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class GroupSupplierController : Controller
    {
        // GET: GroupSupplier
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageGroupSupplier()
        {
            return View();
        }
    }
}