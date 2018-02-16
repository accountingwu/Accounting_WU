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
    public class ManageICdbStockController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageICdbStock
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageICdbStock(int? page, string sortOrder)
        {
            ViewBag.wcodeSortParm = String.IsNullOrEmpty(sortOrder) ? "wcode" : "";
            ViewBag.wname1SortParm = String.IsNullOrEmpty(sortOrder) ? "wname1" : "";
            ViewBag.wname2SortParm = String.IsNullOrEmpty(sortOrder) ? "wname2" : "";
            ViewBag.wtypeSortParm = String.IsNullOrEmpty(sortOrder) ? "wtype" : "";
            List<Warehouse> warehouse = _db.Warehouse.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = warehouse.ToPagedList(pageNumber, pageSize);
            List<Branch> branch = _db.Branch.ToList();
            ViewBag.branch = branch;
            List<t_warehouse_type> warehouseType = _db.t_warehouse_type.ToList();
            switch (sortOrder)
            {
                case "wcode":
                    warehouse = _db.Warehouse.OrderBy(s => s.wcode).ToList();
                    break;
                case "wname1":
                    warehouse = _db.Warehouse.OrderBy(s => s.wname1).ToList();
                    break;
                case "wname2":
                    warehouse = _db.Warehouse.OrderBy(s => s.wname2).ToList();
                    break;
                case "wtype":
                    warehouseType = _db.t_warehouse_type.OrderBy(s => s.whtype_id).ToList();
                    break;
                default:
                    warehouse = warehouse.OrderByDescending(s => s.bciid).ToList();
                    break;

            }
            
            ViewBag.warehouseType = warehouseType;
            ViewBag.sortOrder = sortOrder;
            return View();
        }

        public ActionResult ShowTableWarehouse(int id)
        {
            var warehouse = _db.Warehouse.Where(p => p.bciid == id).FirstOrDefault();
            return Json(warehouse, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveWarehouse(Models.WarehouseModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.bciid == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Warehouse code = _db.Warehouse.Where(p => p.wcode == data.wcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Warehouse.Add(new DAL.Warehouse
                        {
                            wcode = data.wcode,
                            bcode = data.bcode,
                            wtype = data.wtype,
                            wname1 = data.wname1,
                            wname2 = data.wname2
                            
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.bciid != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Warehouse code = _db.Warehouse.Where(p => p.wcode == data.wcode && p.bciid != data.bciid).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Warehouse edit = _db.Warehouse.Where(p => p.bciid == data.bciid).FirstOrDefault();
                        edit.wcode = data.wcode;
                        edit.bcode = data.bcode;
                        edit.wtype = data.wtype;
                        edit.wname1 = data.wname1;
                        edit.wname2 = data.wname2;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]
        public ActionResult DeleteWarehouse(int? bciid)
        {
            if (bciid != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Warehouse delete = _db.Warehouse.Where(p => p.bciid == bciid).FirstOrDefault();

                _db.Warehouse.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}