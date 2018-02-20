using AccountingSystemProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class VatDesController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: VatDes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageVatDes()
        {
            List<MDVatDes> Vat = _db.MDVatDes.ToList();
            ViewBag.MyData = Vat;

            return View();
        }
        public ActionResult SaveVat(Models.VatDesModel data)
        {
            if (ModelState.IsValid)
            {
              
                    DAL.MDVatDes edit = _db.MDVatDes.Where(p => p.VatDesID == data.VatDesID).FirstOrDefault();
                    edit.Remark = data.Remark;



                    _db.SaveChanges();

                    return Json(true, JsonRequestBehavior.AllowGet);
                
                }

            return View(data);
        }
        public ActionResult ShowTableVat(int id)
        {
            var vat = _db.MDVatDes.Where(p => p.VatDesID == id).FirstOrDefault();
            return Json(vat, JsonRequestBehavior.AllowGet);
        }
    }
}