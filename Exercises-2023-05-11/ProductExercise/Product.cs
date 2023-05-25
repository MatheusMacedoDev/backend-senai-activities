using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductExercise
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float Price { get; set; }

		public Product()
		{
			
		}
		
		public Product(int id, string name, float price)
		{
			this.Id = id;
			this.Name = name;
			this.Price = price;	
		}
	}
}