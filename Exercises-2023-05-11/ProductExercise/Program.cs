using System.Globalization;
using ProductExercise;

Product p1 = new Product(1321, "Computer", 5399.99f);
Product p2 = new Product(1322, "Mouse", 233.99f);

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Create(p1);
shoppingCart.Create(p2);

shoppingCart.Update(1321, new Product(1321, "Computer", 3400.99f));

// shoppingCart.Delete(p1);
// shoppingCart.Delete(p2);

shoppingCart.List();
Console.WriteLine($"Total: { shoppingCart.getTotalPrice().ToString("C", new CultureInfo("pt-BR")) }");