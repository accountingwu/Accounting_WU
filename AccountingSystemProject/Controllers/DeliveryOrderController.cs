using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingSystemProject.DAL;
using PagedList;
using AccountingSystemProject.Models;

namespace AccountingSystemProject.Controllers
{
    public class DeliveryOrderController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: DeliveryOrder
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageDeliveryOrder()
        {
            return View();
        }

    }
}