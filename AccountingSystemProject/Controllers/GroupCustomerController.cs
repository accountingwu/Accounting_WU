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
    public class GroupCustomerController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: GroupCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageGroupCustomer(int? page)
        {
            List<Groupcustomer> groupcustomer = _db.Groupcustomer.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = groupcustomer.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]

        public ActionResult SaveGroupCustomer(Models.GroupCustomerModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.gcusid == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Groupcustomer code = _db.Groupcustomer.Where(p => p.gcuscode == data.gcuscode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Groupcustomer.Add(new DAL.Groupcustomer
                        {
                            gcuscode = data.gcuscode,
                            gcusname1 = data.gcusname1,
                            gcusname2 = data.gcusname2,
                            ccode = data.ccode
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.gcusid != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Groupcustomer code = _db.Groupcustomer.Where(p => p.gcuscode == data.gcuscode && p.gcusid != data.gcusid).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Groupcustomer edit = _db.Groupcustomer.Where(p => p.gcusid == data.gcusid).FirstOrDefault();
                        edit.gcuscode = data.gcuscode;
                        edit.gcusname1 = data.gcusname1;
                        edit.gcusname2 = data.gcusname2;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteGroupCustomer(int gcusid)
        {
            if (gcusid != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Groupcustomer delete = _db.Groupcustomer.Where(p => p.gcusid == gcusid).FirstOrDefault();

                _db.Groupcustomer.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableGroupCustomer(int id)
        {
            var groupcustom = _db.Groupcustomer.Where(p => p.gcusid == id).FirstOrDefault();
            return Json(groupcustom, JsonRequestBehavior.AllowGet);
        }
    }
}