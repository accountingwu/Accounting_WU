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
    public class ManageBusinessTypeController : Controller
    {
        // GET: ManageBusinessType
        public ActionResult Index()
        {
            return View();
        }
    }
}