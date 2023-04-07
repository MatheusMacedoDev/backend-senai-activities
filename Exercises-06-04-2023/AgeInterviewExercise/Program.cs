/*2. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
- Total de Homens;
- Total de Mulheres;
- Média de idade dos Homens;
- Média de idade das mulheres.*/

int menQty = 0,
	womanQty = 0;

decimal menAgeAvarage = 0,
		womanAgeAvarage = 0,
		menTotalAge = 0,
		womanTotalAge = 0;
		
for (int i = 1; i <= 10; i++) 
{
	Console.WriteLine($"Interview #{i}");
	
	Console.Write($"Type the age: ");
	int age = int.Parse(Console.ReadLine());
	
	Console.Write($"Type the weigth: ");
	decimal weigth = decimal.Parse(Console.ReadLine());

	Console.Write($"Type the sex (M/F): ");
	char sex = char.Parse(Console.ReadLine().ToLower());
	
	if (sex == 'm') 
	{
		menQty++;
		menTotalAge += age;
		menAgeAvarage = Math.Round(menTotalAge / (decimal) menQty);	
	} 
	else 
	{
		womanQty++;
		womanTotalAge += age;
		womanAgeAvarage = Math.Round(womanTotalAge / (decimal) womanQty);
	}
	
	Console.Clear();
}

Console.WriteLine($"Men quantity: {menQty}");
Console.WriteLine($"Woman quantity: {womanQty}");
Console.WriteLine($"Men age avarage: {menAgeAvarage}");
Console.WriteLine($"Woman age avarage: {womanAgeAvarage}");
