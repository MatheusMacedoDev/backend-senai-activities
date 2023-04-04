// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

const int DAYS_LIMIT = 31;
const int MONTHS_LIMITS = 12;
const int CURRENT_YEAR = 2013;

int day, month, year; 

// Setting values
Console.Write($"Digite o dia: ");
day = Convert.ToInt32(Console.ReadLine());

Console.Write($"Digite o mês: ");
month = Convert.ToInt32(Console.ReadLine());

Console.Write($"Digite o ano: ");
year = Convert.ToInt32(Console.ReadLine());

// Validating
if (day < 1 || day > DAYS_LIMIT) 
{
	Console.WriteLine($"Data inválida! A quantidade de dias excede 31 ou é menor que 1.");
}
else if (month < 1 || month > MONTHS_LIMITS) 
{
	Console.WriteLine($"Data inválida! A quantidade de meses excede 12 ou é menor que 1.");
} 
else if (year < 0 || year > CURRENT_YEAR) 
{
	Console.WriteLine($"Data inválida! O ano é inferior a zero ou é maior que o atual (2013).");
}
else 
{
	Console.WriteLine($"Data válida!");
}