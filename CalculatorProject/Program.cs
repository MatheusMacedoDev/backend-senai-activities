string input;
string[] inputArray;

char calculationOperator;
int numberA, numberB;
decimal result = 0;

Console.Write($"Type a calculation: ");
input = Console.ReadLine();
inputArray = input.Split(" ");

numberA = int.Parse(inputArray[0]);
calculationOperator = char.Parse(inputArray[1]);
numberB = int.Parse(inputArray[2]);

switch(calculationOperator) 
{
	case '+':
		result = numberA + numberB;
		break;
	case '-':
		result = numberA - numberB;
		break;
	case '*':
		result = numberA * numberB;
		break;
	case '/':
		result = numberA / numberB;
		break;
	default:
		Console.WriteLine($"Invalid operator");
		break;
}

Console.WriteLine($"The operation outcome is: {result}");
