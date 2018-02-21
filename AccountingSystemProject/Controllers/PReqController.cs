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
    public class PReqController : Controller
    {
        // GET: PReq
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        
        public ActionResult ManagePReq()
        {
            List<Depart> depart = _db.Depart.ToList();
            List<Employee> employee = _db.Employee.ToList();
            ViewBag.employee = employee;
            ViewBag.depart = depart;
            return View();
        }
    }
}