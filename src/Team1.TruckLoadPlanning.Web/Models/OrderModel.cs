using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team1.TruckLoadPlanning.Data;

namespace Team1.TruckLoadPlanning.Web.Models
{
    public class OrderModel
    {
        public OrderModel(List<OrderList> orders)
        {
            Orders = orders;  
        }


        public List<OrderList> Orders { get; set; }
    }
}