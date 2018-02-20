using AccountingSystemProject.DAL;
using AccountingSystemProject.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class POController : Controller
    {
        // GET: PO
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        public ActionResult ManagePo()
        {
            List<PR2> purchase = _db.PR2.ToList();
            List<PR_member> purmem = _db.PR_member.Tolist();
            return View();
            
        }
    }
}