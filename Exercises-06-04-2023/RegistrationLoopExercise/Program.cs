// User info
string name = "";
string password = "";

do 
{
	Console.Clear();
	
	Console.Write($"Type the name: ");
	name = Console.ReadLine();

	Console.Write($"Type the password: ");
	password = Console.ReadLine();
	
} while (name == password);
