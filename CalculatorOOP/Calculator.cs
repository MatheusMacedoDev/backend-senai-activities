namespace CalculatorOOP 
{
	public class Calculator 
	{
		private decimal numberA;
		private decimal numberB;
		
		public Calculator (decimal numberA, decimal numberB) 
		{
			this.numberA = numberA;
			this.numberB = numberB;
		}
		
		public decimal sum() 
		{
			return numberA + numberB;
		}

		public decimal subtract() 
		{
			return numberA - numberB;
		} 	
		
		public decimal multiply() 
		{
			return numberA * numberB;
		}
		
		public decimal divide() 
		{
			return numberA / numberB;
		}
		
		public decimal getSecondNumber() 
		{
			return numberB;
		}
		
	}
}