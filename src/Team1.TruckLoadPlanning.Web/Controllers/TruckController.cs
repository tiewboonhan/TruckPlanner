using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team1.TruckLoadPlanning.Web.Models;
using Team1.TruckLoadPlanning.Web.Repositories;

namespace Team1.TruckLoadPlanning.Web.Controllers
{
    public class TruckController : Controller
    {
        TruckRepository truckRepo = new TruckRepository();
        // GET: Truck
        public ActionResult Index()
        {
            var model = new TruckModel(truckRepo.GetTruckData());
            return View(model);
        }
    }
}