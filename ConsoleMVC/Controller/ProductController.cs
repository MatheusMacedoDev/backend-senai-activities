using ConsoleMVC.Model;
using ConsoleMVC.View;

namespace ConsoleMVC.Controller
{
	public class ProductController
	{
		Product productModel;
		ProductView productView;
		
		public ProductController()
		{
			productModel = new Product();
			productView = new ProductView();
		}
		
		public void ListProducts() 
		{
			List<Product> products = Product.Read();
			productView.ListInConsole(products);
		}
		
		public void CreateProduct() 
		{
			Product newProduct = productView.CreateAnswersForUser();
			Product.Create(newProduct);
			productView.CreateLogInConsole(newProduct);
		}

		public void DeleteProduct()
		{
			int code = productView.DeleteAnswerForUser();
			Product.Delete(code);
			productView.DeleteLogInConsole(code);
		}
	}
}