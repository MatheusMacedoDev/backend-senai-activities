using System.Globalization;
using ListTestExercise;

List<Product> products = new List<Product>();


// INSERT

products.Add(new Product(23, "Computer", 1999.99f));

// UPDATE

Product findedProduct = products.Find(x => x.CodeId == 23);
Console.WriteLine($"{products.IndexOf(findedProduct)}");
findedProduct.SetPrice(200);

foreach(Product product in products) 
{
	Console.WriteLine($"{product.CodeId} - {product.Name}: {product.Price.ToString("C", new CultureInfo("en-US"))}");
	
}

