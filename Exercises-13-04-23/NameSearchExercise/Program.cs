/*Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.*/

const int READED_NUMBERS = 10;

string[] names = new string[READED_NUMBERS];
string nameToFind;

Console.WriteLine($"Type ten names:");

for (int i = 0; i < READED_NUMBERS; i++) 
{
	Console.Write($"{i + 1}: ");
	names[i] = Console.ReadLine().ToLower();
}

Console.WriteLine($"");

Console.Write($"Type a name to find: ");
nameToFind = Console.ReadLine().ToLower();

Console.WriteLine($"Result: {findName(nameToFind, names)}");


static string findName(string target, string[] names) 
{
	string log = "Not founded!";
	
	foreach (string name in names) 
	{
		if (target == name) 
		{
			log = "Founded!";
			break;
		}
	}
	
	return log;
} 

