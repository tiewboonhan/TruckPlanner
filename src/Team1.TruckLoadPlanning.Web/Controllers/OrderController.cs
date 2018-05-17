using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Team1.TruckLoadPlanning.Data;
using Team1.TruckLoadPlanning.Web.Models;
using Team1.TruckLoadPlanning.Web.Repositories;

namespace Team1.TruckLoadPlanning.Web.Controllers
{
    public class OrderController : Controller
    {
        OrderRepository orderRepo = new OrderRepository();

        public ActionResult Index()
        {

            List<OrderList> orders = orderRepo.GetOrderData();
            var model = new OrderModel(orders);
            return View(model); 

        }

       

        [System.Web.Http.HttpPost]
        public JsonResult CollectResult()
        {
            List<OrderList> orders = orderRepo.GetOrderData();
            var model = new OrderModel(orders);
            return Json(model.Orders);

        }
    }
}
