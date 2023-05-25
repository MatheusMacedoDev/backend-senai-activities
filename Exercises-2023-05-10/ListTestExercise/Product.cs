using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListTestExercise
{
	public class Product
	{
		public byte CodeId { get; private set; }
		public string Name { get; private set; }
		public float Price { get; private set; }

		public Product() 
		{
			
		}
		
		public Product(byte codeId, string name, float price) 
		{
			this.CodeId = codeId;
			this.Name = name;
			this.Price = price;
		}
		
		public void SetPrice(float newPrice) 
		{
			Price = newPrice;
		}
	}
}