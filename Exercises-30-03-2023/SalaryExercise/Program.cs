﻿/*Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.*/

float salary;
float spends;

Console.Write("Salário: ");
salary = Convert.ToSingle(Console.ReadLine());

Console.Write("Gastos: ");
spends = Convert.ToSingle(Console.ReadLine());

if(spends <= salary)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}
