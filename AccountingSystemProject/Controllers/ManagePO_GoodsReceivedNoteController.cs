using AccountingSystemProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class ManagePO_GoodsReceivedNoteController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManagePO_GoodsReceivedNote
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManagePO_GoodsReceivedNote()
        {
            return View();
        }

    }
}