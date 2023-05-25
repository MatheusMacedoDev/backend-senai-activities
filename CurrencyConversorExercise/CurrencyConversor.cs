using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConversorExercise
{
	
	public static class CurrencyConversor
	{
		private static float REAL_TO_DOLLAR_MULTIPLIER = 0.2f;
		private static float DOLLAR_TO_REAL_MULTIPLIER = 5.01f;

		
		public static float realToDollar(float real) 
		{
			return real * REAL_TO_DOLLAR_MULTIPLIER; 
		}
		
		public static float dollarToReal(float dollar) 
		{
			return dollar * DOLLAR_TO_REAL_MULTIPLIER;
		}
	}
}