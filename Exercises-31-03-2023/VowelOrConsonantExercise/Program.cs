// Faça um programa que verifique se uma letra digitada é vogal ou consoante

// Methods
bool isVowel(char letter) 
{
	if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') 
	{
		return true;
	}
	
	return false;
}

// Program
Console.Write("Digite uma letra: ");
char letter = char.Parse(Console.ReadLine().ToLower());

if (isVowel(letter)) 
{
	Console.WriteLine($"A letra é uma vogal");
} 
else 
{
	Console.WriteLine($"A letra é uma consoante");
}