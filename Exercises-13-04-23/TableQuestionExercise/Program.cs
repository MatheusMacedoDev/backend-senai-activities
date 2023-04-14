/*Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.*/

for (int multiplying = 1; multiplying <= 10; multiplying++) 
{
	for (int multiplier = 1; multiplier <= 10; multiplier++) 
	{
		Console.WriteLine($"{multiplying} X {multiplier} = {multiplying * multiplier}");
	}
	Console.WriteLine($"");
}