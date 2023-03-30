/*Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.*/

float frequence;
float avarage;

Console.Write($"Digite a frequência do aluno (%): ");
frequence = Convert.ToSingle(Console.ReadLine()) / 100;

Console.Write($"Digite a média do aluno: ");
avarage = Convert.ToSingle(Console.ReadLine());

if (frequence < 0.75) 
{
	Console.WriteLine("Reprovado");
}
else if (avarage >= 7) 
{
	Console.WriteLine("Aprovado");
}
else if (avarage >= 3) 
{	
	Console.WriteLine("Recuperação");
}
else
{
	Console.WriteLine("Reprovado");
}