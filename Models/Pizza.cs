﻿using System;
namespace la_mia_pizzeria_static.Models
{
	public class Pizza
	{
		public string Name { get; set; }
		public string Overview { get; set; }
		public string Image { get; set; }
		public double Price { get; set; }

		public Pizza(string name, string overview, string image, double price)
		{
			this.Name = name;
			this.Overview = overview;
			this.Image = image;
			this.Price = price;
		}
	}
}

