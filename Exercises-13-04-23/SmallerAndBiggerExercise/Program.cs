double smaller = 0;
double bigger = 0;

Console.WriteLine($"Type ten numbers:");

for (int i = 1; i <= 10; i++) 
{
	Console.Write($"{i}: ");
	double currentValue = double.Parse(Console.ReadLine());
	
	if (i == 1) 
	{
		smaller = currentValue;
		bigger = currentValue;
	}
	else 
	{
		if (currentValue < smaller) 
		{
			smaller = currentValue;
		}
		else if (currentValue > bigger) 
		{
			bigger = currentValue;
		}
	}
}

Console.WriteLine("");
Console.WriteLine($"Smaller: {smaller}");
Console.WriteLine($"Bigger: {bigger}");
