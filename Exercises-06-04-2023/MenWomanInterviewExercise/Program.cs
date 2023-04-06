/*1. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
A. O número de pessoas que responderam SIM;
B. O número de pessoas que responderam NÃO;
C. O número de mulheres que responderam SIM;
D. A porcentagem de homens que responderam NÃO entre todos
E. Os homens analisados.*/

const int interviwedPeople = 10;

int yesAnswers = 0,
	noAnswers = 0,
	womanYesAnswers = 0,
	menNoAnswers = 0;
	
int mensQty = 0;

Console.WriteLine($"Interview Program");
Console.WriteLine($"Press any key...");
Console.ReadKey();
Console.Clear();



for (int i = 1; i <= interviwedPeople; i++) 
{
	Console.Write($"Type the sex (M/F): ");
	char sex = char.Parse(Console.ReadLine().ToLower());
	
	Console.Write($"Type the answer (Y/N): ");
	char answer  = char.Parse(Console.ReadLine().ToLower());
	
	if (sex == 'm') 
	{
		mensQty++;
		if (answer == 'n') 
			menNoAnswers++;
	}
	else 
	{
		if (answer == 'y')
			womanYesAnswers++;
	}
	
	if(answer == 'y')
		yesAnswers++;
	else
		noAnswers++;

	Console.Clear();
}

Console.WriteLine($"Yes answers: {yesAnswers}");
Console.WriteLine($"No answers: {noAnswers}");
Console.WriteLine($"Woman yes answers: {womanYesAnswers}");
Console.WriteLine($"Men no answers (%): {Math.Round(((decimal) menNoAnswers / (decimal) mensQty * 100))}%");
Console.WriteLine($"Men mens quantity: {mensQty}");
