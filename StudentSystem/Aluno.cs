namespace StudentSystem 
{
	public class Aluno
	{
		private string nome;
		private int idade;
		private string rg;
		private bool bolsista;
		private decimal mediaFinal;
		private decimal mensalidadeIntegral;
		
		public Aluno(string nome, int idade, string rg, bool bolsista, decimal mediaFinal, decimal mensalidadeIntegral) 
		{
			this.nome = nome;
			this.idade = idade;
			this.rg = rg;
			this.bolsista = bolsista;
			this.mediaFinal = mediaFinal;
			this.mensalidadeIntegral = mensalidadeIntegral;
		} 
		
		public void verMediaFinal() 
		{
			Console.WriteLine($"A média final é {mediaFinal}");
		}
		
		public void verMensalidade() 
		{
			decimal mensalidade;
			
			if (bolsista && mediaFinal >= 8) 
			{
				mensalidade = mensalidadeIntegral * 0.5m;
			} 
			else if (bolsista && mediaFinal > 6) 
			{
				mensalidade = mensalidadeIntegral * 0.7m;
			} 
			else 
			{
				mensalidade = mensalidadeIntegral;
			} 
			
			Console.WriteLine($"A mensalidade é {mensalidade}");
		}
	}
}