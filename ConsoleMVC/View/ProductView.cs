using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleMVC.Model;

namespace ConsoleMVC.View
{
	public class ProductView
	{
		public void ListInConsole(List<Product> products) 
		{
			foreach(Product product in products) 
			{
				Console.WriteLine($"{product.Code}: {product.Name}, {product.Price:C2}");
			}
			
			clickForContinue();
		}
		
		public Product CreateAnswersForUser() 
		{
			Console.WriteLine($"Creating a new product:");

			Console.Write($"Code: ");
			int code = int.Parse(Console.ReadLine());
			
			Console.Write($"Name: ");
			string name = Console.ReadLine();

			Console.Write($"Price: ");
			float price = float.Parse(Console.ReadLine());
			
			return new Product(code, name, price);
		}
		
		public void CreateLogInConsole(Product product) 
		{
			Console.WriteLine($"\nProduct {product.Code} created with sucess!");
			clickForContinue();
		}
		
		public int DeleteAnswerForUser() 
		{
			Console.WriteLine($"Deleting a product:");
			Console.Write($"Type the product code: ");
			return int.Parse(Console.ReadLine()); 
		}
		
		public void DeleteLogInConsole(int code) 
		{
			Console.WriteLine($"\nProduct with code {code} has been deleted with sucess!");
			clickForContinue();
		}
		
		private void clickForContinue() 
		{			
			Console.WriteLine($"\nType anything to continue...");
			Console.ReadKey();
			Console.WriteLine("");
		}
	}
}