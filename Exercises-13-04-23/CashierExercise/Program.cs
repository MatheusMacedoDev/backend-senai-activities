/*Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
- Se quantidade &lt;= 5 o desconto será de 2%
- Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
- Se quantidade &gt; 10 o desconto será de 5%
Dica: utilize if / else if / else*/

using System.Globalization;

string productName;
decimal productUnitaryPrice;
int productQuantity;

Console.Write($"Type the product name: ");
productName = Console.ReadLine();

Console.Write($"Type the product unitary price: ");
productUnitaryPrice = decimal.Parse(Console.ReadLine());

Console.Write($"Type the quantity of product: ");
productQuantity = int.Parse(Console.ReadLine());

Console.WriteLine($"Total price: {calculateTotalPrice(productUnitaryPrice, productQuantity).ToString("C", new CultureInfo("pt-BR"))}");


static decimal calculateDiscount(decimal totalPrice, int quantity) 
{
	decimal discount = 0;
	
	if (quantity <= 5) 
	{
		discount = totalPrice * 0.02m;
	} 
	else if (quantity > 5) 
	{
		discount = totalPrice * 0.03m;	
	} 
	else if (quantity > 10) 
	{
		discount = totalPrice * 0.05m;	
	}
	
	return discount;
}

static decimal calculateTotalPrice(decimal productUnitaryPrice, int quantity) 
{
	decimal subtotalPrice = productUnitaryPrice * quantity;
	return (subtotalPrice - calculateDiscount(subtotalPrice, quantity));
}