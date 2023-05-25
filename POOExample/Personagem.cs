namespace POO 
{
	public class Personagem 
	{
		public string nome { get; set; }
		public int idade { get; set; }
		public string armadura { get; set; }
		public string ia { get; set; }
		
		public Personagem(string nome, int idade, string armadura, string ia) 
		{
			this.nome = nome;
			this.idade = idade;
			this.armadura = armadura;
			this.ia = ia;
		}
		
		public void Atacar() 
		{
			Console.WriteLine($"Atacar!");
		}
		
		public void Defender() 
		{
			Console.WriteLine($"Defender!");
		}
		
		public void RestaurarArmadura() 
		{
			Console.WriteLine($"Restaurar armadura!");
		}
	}
}