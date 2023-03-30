/*As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.*/

const float FIRST_APPLE_PRICE = 0.3f;
const float SECOND_APPLE_PRICE = 0.25f;

int boughtApples;
float totalPrice;

Console.Write("Informe o número de maçãs compradas: ");
boughtApples = int.Parse(Console.ReadLine());

if (boughtApples < 12) 
{
	totalPrice = boughtApples * FIRST_APPLE_PRICE;
}
else
{
	totalPrice = boughtApples * SECOND_APPLE_PRICE;
}

Console.WriteLine($"O preço no total é igual a R${Math.Round(totalPrice, 2)}");
