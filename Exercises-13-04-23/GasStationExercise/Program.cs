/*Um posto está vendendo combustíveis com a seguinte tabela de descontos:

Álcool:
. até 20 litros, desconto de 3% por litro Álcool
. acima de 20 litros, desconto de 5% por litro

Gasolina:
. até 20 litros, desconto de 4% por litro Gasolina
. acima de 20 litros, desconto de 6% por litro

Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
Dica: utilize switch case e funções/métodos para otimizar o algorítimo.*/

using System.Globalization;

const decimal alcoholPrice = 4.9m;
const decimal gasPrice = 5.3m;

static decimal fuelTotalPrice(char fuelType, int liters) 
{
	decimal totalPrice = 0;
	
	fuelType = Char.ToLower(fuelType);
	
	switch (fuelType) 
	{
		case 'a':
			if (liters <= 20) 
			{
				totalPrice = alcoholPrice * 0.97m * liters;
			}
			else 
			{
				totalPrice = alcoholPrice * 0.95m * liters;
			}
			break;
		case 'g':
			if (liters <= 20) 
			{
				totalPrice = gasPrice * 0.96m * liters;
			}
			else 
			{
				totalPrice = gasPrice * 0.94m * liters;
			}
			break;
		default:
			Console.WriteLine("Tipo de combustível inválido!");
			break;
	}
	
	return totalPrice;
}



Console.Write($"Escreva o tipo de combustível (A (álcool) ou G (gasolina)): ");
char fuelType = char.Parse(Console.ReadLine());

Console.Write($"Escreva a quantidade de litros: ");
int liters = int.Parse(Console.ReadLine());

Console.WriteLine($"O preço total é {fuelTotalPrice(fuelType, liters).ToString("C", new CultureInfo("pt-BR"))}");

