using CoffeeExercise.CoffeeMachine;

Console.Write($"Avaliable sugar: ");
int avaliableSugar = int.Parse(Console.ReadLine());

CoffeeMachine coffeeMachine = new CoffeeMachine(avaliableSugar);

Console.WriteLine($"Do you want to set sugar? (y/n)");
bool needSugar = Console.ReadLine() == "y";

if (needSugar) 
{
	Console.Write($"How many my master? ");
	int neededSugar = int.Parse(Console.ReadLine());
	
	coffeeMachine.makeCoffee(neededSugar);
} 
else 
{
	coffeeMachine.makeCoffee();
}

