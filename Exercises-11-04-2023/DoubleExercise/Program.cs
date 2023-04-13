int[] numbers = new int[5];

Console.WriteLine($"Type numbers:");
for (int i = 0; i < numbers.Length; i++) 
{
	Console.Write($"{i + 1}: ");
	numbers[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine($"");
Console.WriteLine($"Double:");

foreach (int number in numbers) 
{
	Console.WriteLine($"{number * 2}");
}