bool validAge = false;

do 
{
	Console.WriteLine($"What is the Pericles age?");
	int age = int.Parse(Console.ReadLine());
	
	if(age == 53)
		validAge = true;
	
} while(!validAge);