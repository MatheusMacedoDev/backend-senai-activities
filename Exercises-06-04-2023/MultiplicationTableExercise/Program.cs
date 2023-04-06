int number;

Console.Clear();

Console.WriteLine($"Multiplication table");
Console.WriteLine($"Press any button...");
Console.ReadKey();

Console.Clear();

Console.Write($"Type a number: ");
number = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 1; i <= 10; i++) 
{
	Console.WriteLine($"{number} X {i} = {number * i}");
}