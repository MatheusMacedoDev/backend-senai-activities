using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProductExercise
{
	public class ShoppingCart : IShoppingCart
	{
		private List<Product> shoppingCart = new List<Product>();
		
		public void Create(Product product)
		{
			shoppingCart.Add(product);
		}

		public void Delete(Product product)
		{
			shoppingCart.Remove(product);
		}

		public void List()
		{
			if (shoppingCart.Count > 0 && shoppingCart != null) 
			{	
				foreach(var product in shoppingCart) 
				{
					Console.WriteLine($"Id: {product.Id} - Name: {product.Name} - Price: {product.Price.ToString("C", new CultureInfo("pt-BR"))}");
				}
			}
			else 
			{
				Console.WriteLine($"The shopping cart is empty or null");
			}
		}

		public void Update(int id, Product Product)
		{
			Product findedProduct = shoppingCart.Find(p => p.Id == id);
			shoppingCart.Remove(findedProduct);
			shoppingCart.Add(Product);
		}
		public float getTotalPrice() 
		{
			float totalPrice = 0;
			
			if (shoppingCart.Count > 0 && shoppingCart != null) 
			{
				foreach (Product product in shoppingCart) 
				{
					totalPrice += product.Price;
				}
			}
			
			return totalPrice;
		}
	}
	
}