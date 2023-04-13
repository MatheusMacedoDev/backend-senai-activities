// Faça um programa que gere a série até que o valor seja maior que 500. 

const int valueLimit = 500;

int valueA = 0,
	valueB = 1;

Console.WriteLine($"{valueA}");
Console.WriteLine($"{valueB}");

while (valueB <= valueLimit) 
{
	int newValue = valueA + valueB;

	Console.WriteLine($"{newValue}");

	valueA = valueB;
	valueB = newValue;
}