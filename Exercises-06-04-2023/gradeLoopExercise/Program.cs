decimal grade;
bool valid = false;

while (!valid) 
{
	Console.Clear();
	
	Console.Write($"Type the grade: ");
	grade = decimal.Parse(Console.ReadLine());

	if (grade >= 0 && grade <= 10) 
	{
		valid = true;
	}
	else 
	{
		Console.WriteLine($"Invalid value. Type any button!");
		Console.ReadKey();
	} 
}

Console.WriteLine($"Values received.");


