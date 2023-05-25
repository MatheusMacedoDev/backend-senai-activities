using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeExercise.CoffeeMachine
{
	public class CoffeeMachine
	{
		private int avaliableSugar;
		
		public CoffeeMachine(int avaliableSugar) 
		{
			this.avaliableSugar = avaliableSugar;
		}
		
		public void makeCoffee() 
		{
			if (avaliableSugar >= 10) 
			{
				Console.WriteLine($"Coffee maked with 10g of sugar");
				return;
			}
			Console.WriteLine($"Coffe maked without suggar!");
		}
		
		public void makeCoffee(int requiredSugar) 
		{
			if (avaliableSugar >= requiredSugar) 
			{
				avaliableSugar--;
				Console.WriteLine($"Coffe maked with {requiredSugar}g!");
			}
			else 
			{
				Console.WriteLine($"Insuficient sugar in the machine.");
				makeCoffee();
			}			
		}
	}
}