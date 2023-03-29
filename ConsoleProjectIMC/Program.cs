Console.WriteLine(@"

-------------------------
|                       |
|      IMC Project      |
|                       |
-------------------------

");


Console.Write("What is the name: ");
string name = Console.ReadLine();

Console.Write("What is the age: ");
float age = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the height: ");
float heigth = Convert.ToSingle(Console.ReadLine());

Console.Write("What is the weight: ");
float weight = Convert.ToSingle(Console.ReadLine());

float imc = weight / (float)Math.Pow(heigth, 2);

Console.WriteLine($"The {name}'s IMC is {Math.Round(imc)}!");

