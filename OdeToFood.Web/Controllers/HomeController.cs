using RepairShop.Data.Services;
using RepairShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepairShop.Web.Controllers
{
    public class HomeController : Controller
    {
        IRepairOrderData db;

        public HomeController(IRepairOrderData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}