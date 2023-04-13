/*1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).*/

const int minVoteAge = 16;

static void canVote(int currentYear, int birthYear) 
{
	int age = currentYear - birthYear;
	
	if (age > minVoteAge) 
	{
		Console.WriteLine($"You can vote!");
	} else 
	{
		Console.WriteLine($"You can not vote!");
	}
}

int currentYear;
int birthYear;

Console.Write($"Type the current year: ");
currentYear = int.Parse(Console.ReadLine());

Console.Write($"Type the birth year: ");
birthYear = int.Parse(Console.ReadLine());

canVote(currentYear, birthYear);