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
    public class ManageDeliveryOrderController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: DeliveryOrder
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageDeliveryOrder()
        {
            //ViewBag.pcodeSortParm = String.IsNullOrEmpty(sortOrder) ? "pcode" : "";
            //ViewBag.pname1SortParm = String.IsNullOrEmpty(sortOrder) ? "pname1" : "";
            //ViewBag.pname11SortParm = String.IsNullOrEmpty(sortOrder) ? "pname11" : "";
            //ViewBag.ptypeSortParm = String.IsNullOrEmpty(sortOrder) ? "ptype" : "";
            //ViewBag.pstatusSortParm = String.IsNullOrEmpty(sortOrder) ? "pstatus" : "";
            //ViewBag.prod_idSortParm = String.IsNullOrEmpty(sortOrder) ? "prod_id" : "";


            //int pageSize = 5;
            //int pageNumber = (page ?? 1);

            
            List<@do> DeliverOrder = _db.@do.ToList();
            ViewBag.getDeliverOrder = DeliverOrder;
            List<Employee> emp = _db.Employee.ToList();
            ViewBag.getEmp = emp;
            List<Customer> cus = _db.Customer.ToList();
            ViewBag.getCus = cus;
            List<t_sale_order> so = _db.t_sale_order.ToList();
            ViewBag.getSo = so;
            List<DodocNo> DodocNo = _db.DodocNo.ToList();
            ViewBag.getDodocNo = DodocNo;


            //switch (sortOrder)
            //{
            //    case "pcode":
            //        product = _db.Products.OrderBy(s => s.pcode).ToList();
            //        break;
            //    case "pname1":
            //        product = _db.Products.OrderBy(s => s.pname1).ToList();
            //        break;
            //    case "pname11":
            //        product = _db.Products.OrderBy(s => s.pname11).ToList();
            //        break;
            //    case "ptype":
            //        product = _db.Products.OrderBy(s => s.ptype).ToList();
            //        break;
            //    case "pstatus":
            //        product = _db.Products.OrderBy(s => s.pstatus).ToList();
            //        break;
            //    case "prod_id":
            //        product = _db.Products.OrderBy(s => s.prod_id).ToList();
            //        break;
            //    default:
            //        product = product.OrderByDescending(s => s.prod_id).ToList();
            //        break;
            //}
            //ViewBag.MyData = product.ToPagedList(pageNumber, pageSize);
            //ViewBag.sortOrder = sortOrder;

            return View();

        }

        public ActionResult FindPopCustomersend(int id)
        {
            var cus = _db.Customer.Where(p => p.cust_id == id).FirstOrDefault();
            return Json(cus, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FindPopSO(int id)
        {
            var so = _db.t_sale_order.Where(p => p.so_id == id).FirstOrDefault();
            return Json(so, JsonRequestBehavior.AllowGet);
        }
    }
}