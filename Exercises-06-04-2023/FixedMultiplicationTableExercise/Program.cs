const int tableQuatity = 10;

Console.Clear();

for (int table = 1; table <= tableQuatity; table++) 
{
	Console.WriteLine($"Table for {table}");
	for (int multiplier = 1; multiplier <= 10; multiplier++) 
	{
		Console.WriteLine($"{table} X {multiplier} = {table * multiplier}");
	}
	Console.WriteLine("");
	
}