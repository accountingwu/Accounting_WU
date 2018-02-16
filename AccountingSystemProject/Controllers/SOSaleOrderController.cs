using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AccountingSystemProject.DAL;
using PagedList;
using AccountingSystemProject.Models;

namespace AccountingSystemProject.Controllers
{
    public class SOSaleOrderController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        // GET: SOSaleOrder
        public ActionResult Index()
        {
            return View();
        }


        //เพิ่ม/แก้ไขใบสั่งขาย
        public ActionResult ManageSaleOrder()
        {
            //List<EMCustMedia> media = _db.EMCustMedia.ToList();
            //ViewBag.MyData = media;
            return View();
        }

        public ActionResult FinditemPopup()
        {
            List<Products> product = _db.Products.ToList();
            ViewBag.MyData = product;
            return View();
        }

        [HttpPost]
        public JsonResult ShowTableFindItemPopup(string id)
        {
            var product = _db.Products.Where(p => p.ptype == id)
                .Select(a => new
                {
                    pcode = a.pcode,
                    pname1 = a.pname1,
                    pname11 = a.pname11
                });
            return Json(product);

        }
        public ActionResult GetTableFindItem(int id)
        {
            var item = _db.Products.Where(p => p.prod_id == id).FirstOrDefault();
            return Json(item, JsonRequestBehavior.AllowGet);
        }

    }
}