// Faça um programa que leia três números e mostre o maior e o menor deles.

float number1, number2, number3;
float smaller, bigger;

Console.Write($"Digite o primeiro valor: ");
number1 = float.Parse(Console.ReadLine());

Console.Write($"Digite o segundo valor: ");
number2 = float.Parse(Console.ReadLine());

Console.Write($"Digite o terceiro valor: ");
number3 = float.Parse(Console.ReadLine());

// Searching the biggest
if (number1 > number2 && number1 > number3) 
{
	bigger = number1;
}
else if (number2 > number3) 
{
	bigger = number2;
}
else 
{
	bigger = number3;
}

// Searching the smallest
if (number1 < number2 && number1 < number3)
{
	smaller = number1;
}
else if (number2 < number3) 
{
	smaller = number2;
}
else 
{
	smaller = number3;
}

// Showing results

Console.WriteLine($"Menor valor: {smaller}");
Console.WriteLine($"Maior valor: {bigger}");