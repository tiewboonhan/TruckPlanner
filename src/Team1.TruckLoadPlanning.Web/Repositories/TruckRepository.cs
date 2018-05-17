using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team1.TruckLoadPlanning.Data;

namespace Team1.TruckLoadPlanning.Web.Repositories
{
    public class TruckRepository
    {
        private readonly PlannerEntities _dbContext = new PlannerEntities();

        public List<TruckSummary> GetTruckData()
        {
            var truck = from i in _dbContext.TruckSummaries select i;
            return truck.ToList();
        }
    }
}