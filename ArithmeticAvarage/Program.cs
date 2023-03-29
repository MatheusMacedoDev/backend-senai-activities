// Reseting
Console.Clear();

// Program start
Console.WriteLine("Digite as cinco notas a seguir: ");

// Adding every grade
decimal gradeSum = 0;
for(int i = 1; i <= 5; i++) {
    Console.Write($"Nota {i}: ");
    gradeSum += Convert.ToDecimal(Console.ReadLine());
}

// Pulling out the avarage
decimal avarage = gradeSum / 5;

// Output for user
Console.WriteLine($"A média é igual a {avarage}!");