static void loading(string text, int pointsQty, int timeBetweenPoints) 
{
	Console.Write($"{text}");

	for (int i = 0; i < pointsQty; i++) 
	{
		Console.Write(".");
		Thread.Sleep(timeBetweenPoints);
	}
	
	Console.WriteLine("");
}

loading("CARREGANDO", 48, 10000);