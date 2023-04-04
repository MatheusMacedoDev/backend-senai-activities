/*Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.*/

string[] questions = { "Telefonou para a vítima?", 
					   "Esteve no local do crime?", 
					   "Mora perto da vítima?", 
					   "Devia para a vítima?", 
					   "Já trabalhou com a vítima?" };

int score = 0;

// Questions
for (int i = 0; i < 5; i++) 
{
	Console.Write($"{questions[i]} ");
	string response = Console.ReadLine().ToLower();

	if (response == "sim") 
	{
		score++;
	}
}

// Response
if (score >= 5) 
{
	Console.WriteLine("Culpado!");
} 
else if (score >= 3) 
{
	Console.WriteLine("Cúmplice!");
}
else if (score >= 2) 
{
	Console.WriteLine("Suspeito!");
}
else 
{
	Console.WriteLine("Inocente!");
}