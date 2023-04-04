// Variables

string[] drinks = {"Jack Daniels", "Campari", "Vodka", "Brahma", "Red Label"};
string drink = "";
int drinkId = 0;
bool canAddIce = false;
string iceAddictionResponse = "";
bool iceAddiction = false;

// Cleaning
Console.Clear();

// Apresentation

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
----------------------------------
|                                |
|           Drinks Bar           |
|                                |
----------------------------------
");
Console.ResetColor();

// Choose menu

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Choose a drink in the menu: ");
Console.ResetColor();

for(int index = 0; index < drinks.Length; index++) 
{
	Console.WriteLine($"    {index} - {drinks[index]}");
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"Type the number: ");
Console.ResetColor();
drinkId = int.Parse(Console.ReadLine());

// I think it is much better work with arrays in this case, but I used switch case structure because it is what is required by the exercise statement
switch(drinkId) 
{
	case 0:
		drink =  drinks[0];
		canAddIce = true;
		break;
	case 1:
		drink =  drinks[1];
		break;
	case 2:
		drink =  drinks[2];
		canAddIce = true;
		break;
	case 3:
		drink = drinks[3];
		break;
	case 4:
		drink = drinks[4];
		canAddIce = true;
		break;
	default:
		Console.WriteLine($"Invalid code!");
		break;
}

// Cleaning
Console.Clear();

// Ice addiction
if (canAddIce) 
{
	Console.WriteLine($"Do you need come ice cubes? (yes/no)");
	iceAddictionResponse = Console.ReadLine().ToLower();
	iceAddiction = (iceAddictionResponse == "yes" || iceAddictionResponse == "y") ? true : false;
}

// Cleaning
Console.Clear();

// Results
Console.ForegroundColor = ConsoleColor.Magenta;
if(iceAddiction) 
{
	Console.WriteLine($"You choose {drink} with ice");
} 
else 
{
	Console.WriteLine($"You choose {drink}");
}
Console.ResetColor();