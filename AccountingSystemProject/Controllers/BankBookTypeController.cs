using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class BankBookTypeController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        // GET: BankBookType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageBankBookType(int? page)
        {
            List<MDBankBookType> book = _db.MDBankBookType.ToList();
            

            ViewBag.MyData = book;
           
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = book.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]

        public ActionResult SaveBookType(Models.BankBookType data)
        {


            if (!ModelState.IsValid)
            {
                if (data.BookTypeID == 0)
                {

                    _db = new  QSoft_WUEntities();
                    DAL.MDBankBookType code = _db.MDBankBookType.Where(p => p.BookTypeCode == data.BookTypeCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDBankBookType.Add(new DAL.MDBankBookType
                        {
                            BookTypeCode = data.BookTypeCode,
                            BookTypeName = data.BookTypeName,
                            BookTypeNameEng = data.BookTypeNameEng,
                            Remark = data.Remark
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.BookTypeID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDBankBookType code = _db.MDBankBookType.Where(p => p.BookTypeCode == data.BookTypeCode && p.BookTypeID != data.BookTypeID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDBankBookType edit = _db.MDBankBookType.Where(p => p.BookTypeID == data.BookTypeID).FirstOrDefault();
                        edit.BookTypeCode = data.BookTypeCode;
                        edit.BookTypeName = data.BookTypeName;
                        edit.BookTypeNameEng = data.BookTypeNameEng;
                        edit.Remark = data.Remark;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteBookType(int BookTypeID)
        {
            if (BookTypeID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDBankBookType delete = _db.MDBankBookType.Where(p => p.BookTypeID == BookTypeID).FirstOrDefault();

                _db.MDBankBookType.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableBankBookType(int id)
        {
            var booktype = _db.MDBankBookType.Where(p => p.BookTypeID == id).FirstOrDefault();
            return Json(booktype, JsonRequestBehavior.AllowGet);
        }

    }
}