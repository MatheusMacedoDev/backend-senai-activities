using ElevatorExercise.Elevators;
using ElevatorExercise.Elevators.Exceptions;

Console.Write($"Elevator floors limit: ");
int maxFloor = getNumberInput();

Console.Write($"Elevator capacity: ");
int elevatorCapacity = getNumberInput();

Elevator elevator = new Elevator(maxFloor, elevatorCapacity);

int option = 5;

do 
{
	Console.Clear();
	
	Console.WriteLine($"Current elevator state");
	Console.WriteLine($"Floor: { elevator.CurrentFloor }");
	Console.WriteLine($"Peoples: { elevator.CurrentPeopleQuantity }");
	Console.WriteLine($"");
	
	Console.WriteLine($"Options list:");
	Console.WriteLine($"1 - One people enter the elevator");
	Console.WriteLine($"2 - One people exit the elevator");
	Console.WriteLine($"3 - Go up a floor");
	Console.WriteLine($"4 - Go down a floor");
	Console.WriteLine($"5 - Exit the system");
	
	Console.Write($"Type a option: ");
	option = getNumberInput();
	
	switch (option) 
	{
		case 1:
			try 
			{
				elevator.enter();
			}
			catch (LotOfPeopleException exception) 
			{
				Console.WriteLine(exception.ToString());
			}
			break;
		case 2:
			elevator.exit();
			break;
		case 3:
			elevator.stepUp();
			break;
		case 4:
			elevator.stepDown();
			break;
		case 5:
			break;
		default:
			Console.WriteLine($"Invalid option! Type another option.");
			break;
	}
	
	Console.WriteLine($"");
	Console.WriteLine($"Type any key to continue...");
	Console.ReadKey();
}
while (option != 5);

static int getNumberInput() 
{
	int number = 0;
	string numberAsString = Console.ReadLine();

	while (!int.TryParse(numberAsString, out number)) 
	{
		Console.Write($"Type a number: ");
		numberAsString = Console.ReadLine();
	}
	
	return number;
}
