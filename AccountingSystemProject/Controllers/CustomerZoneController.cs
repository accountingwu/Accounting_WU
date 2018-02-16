using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class CustomerZoneController : Controller
    {
        // GET: CustomerZone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageCustomerZone()
        {
            return View();
        }
    }
}