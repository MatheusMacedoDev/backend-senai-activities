// const double PI = 3.1415;

// int number = 120; // 4 bytes
// long longNumber = 1209018309724987L; // 8 bytes
// double numberWithFloatPoint = 1.2; // 8 bytes
// char fistNameLetter = 'M'; // 2 bytes
// string name = "Matheus"; // 14 bytes (2 bytes por character)
// bool value = false; // 1 bit

// number = 1000;


// Console.WriteLine(number);
// Console.WriteLine(longNumber);
// Console.WriteLine(numberWithFloatPoint);
// Console.WriteLine(fistNameLetter);
// Console.WriteLine("O meu nome: " + name);
// Console.WriteLine(value);
// Console.WriteLine(PI);

// // Operators

// Console.WriteLine($"Soma: {number + longNumber}");
// Console.WriteLine($"Soma: {--number}");
// Console.WriteLine($"Soma: {++number}");
// Console.WriteLine($"Soma: {number * 5}");
// Console.WriteLine($"Soma: {number / 5}");
// Console.WriteLine($"Soma: {number % 3}");

// // Conditionals

// Console.Clear();

// int numberA = 9, numberB = 12;
// int sum = numberA + numberB;

// Console.WriteLine($"{numberA + numberB}");

// if(sum > 20)
// {
//     Console.WriteLine("It is a long number");
// }
// else 
// {
//     Console.WriteLine("It is a short number");
// } 

// // Operators

// Console.Clear();

// // Attribution
// int x = 15; 
// x += 10; 
// x -= 2;
// x *= 3;
// x /= 2;

// // Arithmetic
// Console.WriteLine(3 + 4);
// Console.WriteLine(3 - 4);
// Console.WriteLine(3 * 4);
// Console.WriteLine(3 / 4);
// Console.WriteLine(3 % 4);

// // Comparation
// Console.Clear();
// int a = 3, b = 2;
// Console.WriteLine(a == b);
// Console.WriteLine(a >= b);
// Console.WriteLine(a < b);
// Console.WriteLine(a != b);

// // Logic operators
// Console.Clear();
// Console.WriteLine(true && false);
// Console.WriteLine(true & true);
// Console.WriteLine(true || false);
// Console.WriteLine(!false);
// Console.WriteLine(true ^ true);

//Inputs
Console.WriteLine("What is your name? ");
string name = Console.ReadLine();

Console.WriteLine("What is your height? ");
float height = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("What is your weight? ");
float weight = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("How old are you? ");
int age = Convert.ToInt32(Console.ReadLine());

// Processing
float imc = weight / (height * height);

// Output
Console.WriteLine($"{height} - {weight}");

Console.WriteLine($"The IMC of {name} is {Math.Round(imc, 1)}!");


