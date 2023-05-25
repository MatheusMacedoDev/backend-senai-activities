using System.Globalization;
using CurrencyConversorExercise;




byte option;

do 
{	
	Console.Clear();

	Console.Write($"Type any value to convert: ");
	float value = float.Parse(Console.ReadLine());

	Console.Clear();

	Console.WriteLine($"Menu:");
	Console.WriteLine($"1 - Real to Dollar");
	Console.WriteLine($"2 - Dollar to Real");
	Console.WriteLine($"3 - Exit");

	Console.WriteLine($"");

	Console.Write($"Type an option: ");
	option = byte.Parse(Console.ReadLine());

	switch(option) 
	{
		case 1:
			Console.WriteLine($"Value in Dollar is {CurrencyConversor.realToDollar(value):c}");
			break;
		case 2:
			Console.WriteLine($"Value in Dollar is {CurrencyConversor.dollarToReal(value).ToString("C2", new CultureInfo("en-US"))}");
			break;
		case 3:
			break;
		default:
			break;
	}
	
	Console.ReadKey();
}
while(option != 3);



