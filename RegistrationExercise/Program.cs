bool invalidName = true, 
	 invalidAge = true,
	 invalidSalary = true,
	 invalidCivilState = true;

string name = "";
int age = -1;
decimal salary = 0;
char civilState;

while(invalidName) 
{	
	Console.Clear();
	Console.Write($"Type the name: ");
	name = Console.ReadLine();
	invalidName = name == "";
	
	if(invalidName) 
	{
		Console.WriteLine($"Invalid name!");
		Console.ReadKey();
	}
}

while(invalidAge) 
{
	Console.Clear();
	Console.Write($"Type the age: ");
	age = int.Parse(Console.ReadLine());
	invalidAge = age < 0 || age > 100;
	
	if(invalidAge) 
	{
		Console.WriteLine($"Invalid age!");
		Console.ReadKey();
	}
}

while(invalidSalary) 
{
	Console.Clear();
	Console.Write($"Type the salary: ");
	salary = decimal.Parse(Console.ReadLine());
	invalidSalary = salary <= 0;

	if(invalidSalary) 
	{
		Console.WriteLine($"Invalid salary!");
		Console.ReadKey();
	}
}

while(invalidCivilState) 
{
	Console.Clear();
	Console.Write($"Type the civil state: ");
	civilState = char.Parse(Console.ReadLine());
	invalidCivilState = civilState != 's' &&
						civilState != 'c' &&
						civilState != 'v' &&
						civilState != 'd';

	if(invalidCivilState) 
	{
		Console.WriteLine($"Invalid civil state!");
		Console.ReadKey();
	}
}

Console.Clear();
Console.WriteLine($"Every data informed was approved. Thanks for use!");

