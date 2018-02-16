using AccountingSystemProject.DAL;
using AccountingSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class FactoryController : Controller
    {
        // GET: Factory
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageFactory()
        {
            List<Factory> factory = _db.Factory.ToList();
            List<Branch> brach = _db.Branch.ToList();
            //List<Corp> corp = _db.Corp.ToList();
            ViewBag.MyData = factory;
            ViewBag.brach = brach;
            return View();
        }

        [HttpPost]

        public ActionResult SaveFactory(Models.FactoryModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.fac_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Factory code = _db.Factory.Where(p => p.fcode == data.fcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Factory.Add(new DAL.Factory
                        {
                            fcode = data.fcode,
                            fname1 = data.fname1,
                            fname2 = data.fname2,
                            ccode = data.ccode,
                            bcode = data.bcode,
                            fcap = data.fcap
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.fac_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Factory code = _db.Factory.Where(p => p.fcode == data.fcode && p.fac_id != data.fac_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Factory edit = _db.Factory.Where(p => p.fac_id == data.fac_id).FirstOrDefault();
                        edit.fcode = data.fcode;
                        edit.fname1 = data.fname1;
                        edit.fname2 = data.fname2;
                        edit.ccode = data.ccode;
                        edit.bcode = data.bcode;
                        edit.fcap = data.fcap;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteFactory(int fac_id)
        {
            if (fac_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Factory delete = _db.Factory.Where(p => p.fac_id == fac_id).FirstOrDefault();

                _db.Factory.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableFactory(int id)
        {
            var factory = _db.Factory.Where(p => p.fac_id == id).FirstOrDefault();
            return Json(factory, JsonRequestBehavior.AllowGet);
        }


        //public ActionResult ChoosDropDown()
        //{
        //    BrachModel brach = new BrachModel();
        //    //brach.getbrachlist = _db.Branch.Select(b => new BrachModel { b_id = b.b_id, bname1 = b.bname1 }).ToList();

        //    var getbrach = brach.getbrachlist.ToList();
        //    SelectList list = new SelectList(getbrach, "b_id", "bname1");
        //    ViewBag.brach1 = list;
        //    return View();
        //}




    }
}
