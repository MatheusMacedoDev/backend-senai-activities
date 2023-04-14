/*Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
declarado.*/

static int[] fillIntArray(int size) 
{
	int[] array = new int[size];
	
	Console.WriteLine($"Type the numbers:");
	for (int i = 0; i < size; i++) 
	{
		Console.Write($"{i + 1}: ");
		array[i] = int.Parse(Console.ReadLine());
	}
	Console.WriteLine($"");
	
	return array;
}

static int[] reverseIntArray(int[] array) 
{
	int size = array.Length;
	int[] reverseArray = new int[size];
	
	for (int i = 0; i < size; i++) 
	{
		reverseArray[i] = array[size - i - 1];
	}
	
	return reverseArray;
} 

int[] numberArray = fillIntArray(15);
int[] reverseNumberArray = reverseIntArray(numberArray);

Console.WriteLine($"Reverse array: ");
foreach (int number in reverseNumberArray) 
{
	Console.WriteLine(number);
} 

