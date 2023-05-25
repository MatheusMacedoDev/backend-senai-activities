using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductExercise
{
	public interface IShoppingCart
	{
		void Create(Product product);
		void List();
		void Update(int id, Product Product);
		void Delete(Product product);
	}
}