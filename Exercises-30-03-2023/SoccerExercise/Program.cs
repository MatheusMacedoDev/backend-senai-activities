/*Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.*/

int teamAPoints = 0, teamBPoints = 0;

Console.WriteLine($"Digite os gols do time A: ");
teamAPoints = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite os gols do time B: ");
teamBPoints = Convert.ToInt32(Console.ReadLine());

if (teamAPoints > teamBPoints)
{
    Console.WriteLine($"O time A foi vencedor!");
}
else if (teamAPoints == teamBPoints)
{
    Console.WriteLine($"Houve um empate!");   
}
else
{
    Console.WriteLine($"O time B foi vencedor!");
}