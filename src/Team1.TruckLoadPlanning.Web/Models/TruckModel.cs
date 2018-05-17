using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team1.TruckLoadPlanning.Data;

namespace Team1.TruckLoadPlanning.Web.Models
{
    public class TruckModel
    {
        public TruckModel(List<TruckSummary> trucks)
        {
            Trucks = trucks;
            Dictionary<string, int> trucksummary = new Dictionary<string, int>();
            var results = from p in trucks
                          group p by p.TruckType into g
                          select new { TruckType = g.Key, Total = g.Count() };

            foreach (var item in results)
            {
                trucksummary.Add(item.TruckType, item.Total);
            }

            TruckSummary = trucksummary;
        }


        public List<TruckSummary> Trucks { get; set;}
        public Dictionary<string,int> TruckSummary { get; set; }
    }
}