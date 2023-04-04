// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

float radius, diameter, length, area;

Console.Write("Raio da circunferência: ");
radius = float.Parse(Console.ReadLine());

diameter = radius * 2;
length = diameter * (float) Math.PI;
area = (float) (Math.PI * Math.Pow(radius, 2));

Console.WriteLine($"Diâmetro: {Math.Round(diameter, 2)}");
Console.WriteLine($"Comprimento: {Math.Round(length, 2)}");
Console.WriteLine($"Área: {Math.Round(area, 2)}");
