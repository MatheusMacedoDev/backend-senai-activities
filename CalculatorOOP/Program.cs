using CalculatorOOP;

char operation;
decimal fistNumber;
decimal secondNumber;
decimal outcome = 0;
bool error = false;
bool continueProgram = true;

Calculator calculator;

while (continueProgram) 
{
	Console.Clear();
	
	Console.Write($"Set an operation: ");
	operation = char.Parse(Console.ReadLine());

	Console.Write($"Type the first number: ");
	fistNumber = decimal.Parse(Console.ReadLine());

	Console.Write($"Type the second number: ");
	secondNumber = decimal.Parse(Console.ReadLine());

	calculator = new Calculator(fistNumber, secondNumber);

	switch (operation) 
	{
		case '+':
			outcome = calculator.sum();
			break;
		case '-':
			outcome = calculator.subtract();
			break;
		case '*':
			outcome = calculator.multiply();
			break;
		case '/':
			if (calculator.getSecondNumber() == 0) 
			{
				Console.WriteLine($"You can not divide by 0");
				error = true;
				break;
			}
			outcome = calculator.divide();
			break;
		default:
			break;
	}

	if (!error)
		Console.WriteLine($"Outcome: {outcome}");

	Console.WriteLine($"Type any button to continue...");
	Console.ReadKey();

	Console.WriteLine($"Continue? (y/n)");
	continueProgram = Console.ReadLine().ToLower() == "y";
}
