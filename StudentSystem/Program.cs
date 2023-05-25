using StudentSystem;

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("RG: ");
string rg = Console.ReadLine();

Console.Write("Bolsista (s/n): ");
bool bolsista = Console.ReadLine().ToLower() == "s";

Console.Write("Média final: ");
decimal mediaFinal = decimal.Parse(Console.ReadLine());

Console.Write($"Valor total da mensalidade: ");
decimal mensalidadeTotal = decimal.Parse(Console.ReadLine());

Aluno aluno = new Aluno(nome, idade, rg, bolsista, mediaFinal, mensalidadeTotal);

Console.Clear();

Console.WriteLine(@$"
1 - Ver media final
2 - Ver mensalidade
0 - Sair
");


int opcao = int.Parse(Console.ReadLine());
switch (opcao) 
{
	case 0:
		Console.WriteLine($"Saindo...");
		break;
	case 1:
		aluno.verMediaFinal();		
		break;
	case 2:
		aluno.verMensalidade();		
		break;
	default:
		break;
}