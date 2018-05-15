using Team1.TruckLoadPlanning.Business;
using Team1.TruckLoadPlanning.Business.Algorithms;
using Team1.TruckLoadPlanning.Business.Entities;
using Team1.TruckLoadPlanning.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;

namespace Team1.TruckLoadPlanning.Web.Controllers
{
	/// <summary>
	/// The API controller for container packing.
	/// </summary>
	public class ContainerPackingController : ApiController
	{
		/// <summary>
		/// Posts the specified packing request.
		/// </summary>
		/// <param name="request">The packing request.</param>
		/// <returns>A container packing result with lists of packed and unpacked items.</returns>
		[HttpPost]
		public List<ContainerPackingResult> Post([FromBody]ContainerPackingRequest request)
		{
			return PackingService.Pack(request.Containers, request.ItemsToPack, new List<int>() { 1 });//request.AlgorithmTypeIDs
		}

        [HttpGet]
        public List<Container> GenerateBoxes()
        {
            List<Container> containers = new List<Container>();
            containers.Add(new Container(1000, "box1", 15, 13, 9));
            containers.Add(new Container(1000, "box2", 15, 13, 9));
            return containers;
        }
    }
}