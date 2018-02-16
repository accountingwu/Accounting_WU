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
    public class ManageBaddEditScrapController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageBaddEditScrap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageBaddEditScrap(int? page)
        {
            List<Scrap> BaddEditScrap = _db.Scrap.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = BaddEditScrap.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]

        public ActionResult SaveScrap(Models.BadScrapModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.scid == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Scrap code = _db.Scrap.Where(p => p.scode == data.scode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Scrap.Add(new DAL.Scrap
                        {
                            scode = data.scode,
                            scname1 = data.scname1,
                            scname2 = data.scname2,
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
                if (data.scid != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Scrap code = _db.Scrap.Where(p => p.scode == data.scode && p.scid != data.scid).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Scrap edit = _db.Scrap.Where(p => p.scid == data.scid).FirstOrDefault();
                        edit.scode = data.scode;
                        edit.scname1 = data.scname1;
                        edit.scname2 = data.scname2;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteScrapp(int scid)
        {
            if (scid != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Scrap delete = _db.Scrap.Where(p => p.scid == scid).FirstOrDefault();

                _db.Scrap.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableScrapp(int id)
        {
            var badscrap = _db.Scrap.Where(p => p.scid == id).FirstOrDefault();
            return Json(badscrap, JsonRequestBehavior.AllowGet);
        }

    }

}