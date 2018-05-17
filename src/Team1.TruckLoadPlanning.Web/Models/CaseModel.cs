using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team1.TruckLoadPlanning.Data;

namespace Team1.TruckLoadPlanning.Web.Models
{
    public class CaseModel
    {
        public CaseModel()
        {
        }


        public CaseModel(OrderList order)
        {
            Order = order; 
        }

        public OrderList Order { get; set; }

    }
}