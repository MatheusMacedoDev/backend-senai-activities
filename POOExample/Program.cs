using POO;

internal class Program
{
	private static void Main(string[] args)
	{	
		Console.WriteLine($"Escreva o nome:");
		string nomePersonagem = Console.ReadLine();

		Console.WriteLine($"Escreva a idade:");
		int idadePersonagem = int.Parse(Console.ReadLine());

		Console.WriteLine($"Escreva a armadura:");
		string armaduraPersonagem = Console.ReadLine();

		Console.WriteLine($"Escreva a IA:");
		string iaPersonagem = Console.ReadLine();
		
		Personagem tony = new Personagem(nomePersonagem, idadePersonagem, armaduraPersonagem, iaPersonagem);
		
		Console.WriteLine(tony.nome);
		Console.WriteLine(tony.idade);
		Console.WriteLine(tony.armadura);
		Console.WriteLine(tony.ia);
		
		tony.Atacar();
		tony.Defender();
		tony.RestaurarArmadura();
	}
}