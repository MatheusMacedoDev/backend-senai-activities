string[] names = new string[5];
int[] ages = new int[5];

Console.WriteLine($"Type the data:");
for (int i = 0; i < 5; i++) 
{
	Console.WriteLine($"People #{i + 1}");
	
	Console.Write($"Name: ");
	names[i] = Console.ReadLine();
	
	Console.Write($"Age: ");
	ages[i] = int.Parse(Console.ReadLine());

	Console.WriteLine($"");
}

Console.Clear();

for (int i = 0; i < 5; i++) 
{
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine($"{i + 1}) nome: {names[i]}");

	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine($"idade: {ages[i]}");
	
	Console.ResetColor();
}