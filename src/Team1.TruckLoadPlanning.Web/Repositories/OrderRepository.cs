using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team1.TruckLoadPlanning.Data;

namespace Team1.TruckLoadPlanning.Web.Repositories
{
    public class OrderRepository
    {
        private readonly PlannerEntities _dbContext = new PlannerEntities();
        
        public List<OrderList> GetOrderData()
        {
            var order =  from i in _dbContext.OrderLists select i;
            return order.ToList();
        }

        public OrderList GetOrder(string caseNo)
        {
            var order = from i in _dbContext.OrderLists where i.CaseNo == caseNo select i;
            return order.ToList().FirstOrDefault();
        }

    }
}