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
    public class QsoftDepartController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageDepart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageDepart(int? page)
        {
            List<Depart> depart = _db.Depart.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = depart.ToPagedList(pageNumber, pageSize);           
            return View();
        }


        [HttpPost]

        public ActionResult SaveDepart(Models.DepartModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.d_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Depart code = _db.Depart.Where(p => p.dcode == data.dcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Depart.Add(new DAL.Depart
                        {
                            dcode = data.dcode,
                            dname1 = data.dname1,
                            dname2 = data.dname2
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.d_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Depart code = _db.Depart.Where(p => p.dcode == data.dcode && p.d_id != data.d_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Depart edit = _db.Depart.Where(p => p.d_id == data.d_id).FirstOrDefault();
                        edit.dcode = data.dcode;
                        edit.dname1 = data.dname1;
                        edit.dname2 = data.dname2;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteDepart(int? d_id)
        {
            if (d_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Depart delete = _db.Depart.Where(p => p.d_id == d_id).FirstOrDefault();

                _db.Depart.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableDepart(int id)
        {
            var depart = _db.Depart.Where(p => p.d_id == id).FirstOrDefault();
            return Json(depart, JsonRequestBehavior.AllowGet);
        }

    }
}