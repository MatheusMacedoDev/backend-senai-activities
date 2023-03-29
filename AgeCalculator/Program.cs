Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@"

-------------------------------------
|   Welcome to the Age Calculator   |
-------------------------------------

");
Console.ResetColor();


Console.Write("How old are you? ");
int ?age = int.Parse(Console.ReadLine());

Console.WriteLine($"Months: {age * 12}");
Console.WriteLine($"Days: {age * 365}");
Console.WriteLine($"Hours: {age * 365 * 24}");
Console.WriteLine($"Minutes: {age * 365 * 24 * 60}");