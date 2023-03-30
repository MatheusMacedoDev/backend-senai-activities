/*Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
Sendo    que:    
− Triângulo    Equilátero:    possui    os    3    lados    iguais.
− Triângulo    Isóscele:    possui    2    lados    iguais.
− Triângulo    Escaleno:    possui    3    lados    diferentes.*/

float sideA, sideB, sideC;

Console.Write($"Lado A: ");
sideA = Convert.ToSingle(Console.ReadLine());

Console.Write($"Lado B: ");
sideB = Convert.ToSingle(Console.ReadLine());

Console.Write($"Lado C: ");
sideC = Convert.ToSingle(Console.ReadLine());

if (sideA == sideB && sideB == sideC)
{
	Console.WriteLine($"Triângulo Equilátero");
}
else if (sideA == sideB || sideA == sideC || sideB == sideC) 
{
	Console.WriteLine($"Triângulo Isósceles");
}
else 
{
	Console.WriteLine($"Triângulo Escaleno");
}
