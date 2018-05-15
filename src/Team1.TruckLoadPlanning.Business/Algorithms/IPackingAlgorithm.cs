﻿using Team1.TruckLoadPlanning.Business.Entities;
using System.Collections.Generic;

namespace Team1.TruckLoadPlanning.Business.Algorithms
{
	/// <summary>
	/// Interface for the packing algorithms in this project.
	/// </summary>
	public interface IPackingAlgorithm
	{
		/// <summary>
		/// Runs the algorithm on the specified container and items.
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="items">The items to pack.</param>
		/// <returns>The algorithm packing result.</returns>
		AlgorithmPackingResult Run(Container container, List<Item> items);
	}
}