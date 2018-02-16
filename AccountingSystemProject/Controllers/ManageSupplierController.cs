using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingSystemProject.DAL;
using AccountingSystemProject.Models;
using PagedList;

namespace AccountingSystemProject.Controllers
{
    public class ManageSupplierController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageSupplier
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageSupplier(int? page)
        {
            
            var Acc = (from c in _db.MDAcc
                       select new AccViw
                       {
                           AccID = c.AccID,
                           AccCode = c.AccCode,
                           AccName = c.AccName,
                           AccNameEng = c.AccNameEng,
                       }).ToList();
            List<GroupSupplier> group = _db.GroupSupplier.ToList();
            List<Supplier> sup = _db.Supplier.ToList();
            ViewBag.MyData = Acc;
            ViewBag.MyData2 = sup;
            ViewBag.MyData1 = group;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData2 = sup.ToPagedList(pageNumber, pageSize);
            return View();
        }
        public ActionResult Save(Models.SupplierModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.sup_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Supplier code = _db.Supplier.Where(p => p.supcode == data.supcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Supplier.Add(new DAL.Supplier
                        {
                            sup_id = data.sup_id,
                            supcode = data.supcode,
                            supname1 = data.supname1,
                            supname11 = data.supname11,
                            supname2 = data.supname2,
                            supname21 = data.supname21,
                            supaddress1 = data.supaddress1,
                            supaddress2 = data.supaddress2,
                            supzip = data.supzip,
                            suptel = data.suptel,
                            supfax = data.supfax,
                            supmobile = data.supmobile,
                            dateinact = data.dateinact,
                            status = data.status,
                            p_id = data.p_id,
                            t_id = data.t_id,
                            niti = data.niti,
                            acc_code = data.acc_code,
                            gsupid = data.gsupid,
                            contaddress1 = data.contaddress1,
                            contaddress2 = data.contaddress2,
                            contzip = data.contzip,
                            notebill = data.notebill,
                            noteth = data.noteth,
                            noteen = data.noteen,
                            credittermday = data.credittermday,
                            creditmoney = data.creditmoney,
                            contname = data.contname,
                            ncostcode = data.ncostcode,
                            ndiscountcode = data.ndiscountcode,
                            note1 = data.note1,
                            note2 = data.note2,
                            note3 = data.note3,
                            note4 = data.note4,
                            note5 = data.note5,
                            note6 = data.note6,
                            note7 = data.note7,
                            note8 = data.note8,
                            note9 = data.note9,
                            note10 = data.note10,
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
                if (data.sup_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Supplier code = _db.Supplier.Where(p => p.supcode == data.supcode && p.sup_id != data.sup_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Supplier edit = _db.Supplier.Where(p => p.sup_id == data.sup_id).FirstOrDefault();

                        edit.sup_id = data.sup_id;
                        edit.supcode = data.supcode;
                        edit.supname1 = data.supname1;
                        edit.supname11 = data.supname11;
                        edit.supname2 = data.supname2;
                        edit.supname21 = data.supname21;
                        edit.supaddress1 = data.supaddress1;
                        edit.supaddress2 = data.supaddress2;
                        edit.supzip = data.supzip;
                        edit.suptel = data.suptel;
                        edit.supfax = data.supfax;
                        edit.supmobile = data.supmobile;
                        edit.dateinact = data.dateinact;
                        edit.status = data.status;
                        edit.p_id = data.p_id;
                        edit.t_id = data.t_id;
                        edit.niti = data.niti;
                        edit.acc_code = data.acc_code;
                        edit.gsupid = data.gsupid;
                        edit.contaddress1 = data.contaddress1;
                        edit.contaddress2 = data.contaddress2;
                        edit.contzip = data.contzip;
                        edit.notebill = data.notebill;
                        edit.noteth = data.noteth;
                        edit.noteen = data.noteen;
                        edit.credittermday = data.credittermday;
                        edit.creditmoney = data.creditmoney;
                        edit.contname = data.contname;
                        edit.ncostcode = data.ncostcode;
                        edit.ndiscountcode = data.ndiscountcode;
                        edit.note1 = data.note1;
                        edit.note2 = data.note2;
                        edit.note3 = data.note3;
                        edit.note4 = data.note4;
                        edit.note5 = data.note5;
                        edit.note6 = data.note6;
                        edit.note7 = data.note7;
                        edit.note8 = data.note8;
                        edit.note9 = data.note9;
                        edit.note10 = data.note10;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        public ActionResult FinditemPopupSup(int id)
        {
            var Acc = _db.MDAcc.Where(p => p.AccID == id).FirstOrDefault();
            return Json(Acc, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowTableSupplier(int id)
        {
            _db = new QSoft_WUEntities();
            var Sup = (from data in _db.Supplier
                        join d in _db.MDAcc on data.acc_code equals d.AccCode
                        select new Supview
                        {
                            AccID = d.AccID,
                            acc_code = d.AccCode,
                            AccName = d.AccName,
                            sup_id = data.sup_id,
                            supcode = data.supcode,
                            supname1 = data.supname1,
                            supname11 = data.supname11,
                            supname2 = data.supname2,
                            supname21 = data.supname21,
                            supaddress1 = data.supaddress1,
                            supaddress2 = data.supaddress2,
                            supzip = data.supzip,
                            suptel = data.suptel,
                            supfax = data.supfax,
                            supmobile = data.supmobile,
                            dateinact = data.dateinact,
                            status = data.status,
                            p_id = data.p_id,
                            t_id = data.t_id,
                            niti = data.niti,
                            gsupid = data.gsupid,
                            contaddress1 = data.contaddress1,
                            contaddress2 = data.contaddress2,
                            contzip = data.contzip,
                            notebill = data.notebill,
                            noteth = data.noteth,
                            noteen = data.noteen,
                            credittermday = data.credittermday,
                            creditmoney = data.creditmoney,
                            contname = data.contname,
                            ncostcode = data.ncostcode,
                            ndiscountcode = data.ndiscountcode,
                            note1 = data.note1,
                            note2 = data.note2,
                            note3 = data.note3,
                            note4 = data.note4,
                            note5 = data.note5,
                            note6 = data.note6,
                            note7 = data.note7,
                            note8 = data.note8,
                            note9 = data.note9,
                            note10 = data.note10,
                            
                        }).Where(Supview => Supview.sup_id == id).FirstOrDefault();
            return Json(Sup, JsonRequestBehavior.AllowGet);

            //var Sup = _db.Supplier.Where(p => p.sup_id == id).FirstOrDefault();
            //return Json(Sup, JsonRequestBehavior.AllowGet);
        }
    }
}