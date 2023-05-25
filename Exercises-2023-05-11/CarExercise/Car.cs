using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarExercise
{
	public class Car
	{
		public string Brand { get; private set; }
		public string Color { get; set; }

		public Car()
		{
			
		}
		
		public Car(string brand, string color)
		{
			this.Brand = brand;
			this.Color = color;
		}
	}
}