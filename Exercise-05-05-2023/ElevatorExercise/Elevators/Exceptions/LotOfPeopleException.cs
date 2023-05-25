using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorExercise.Elevators.Exceptions
{
	public class LotOfPeopleException : Exception
	{
		private string message;
		public LotOfPeopleException(string message) 
		{
			this.message = message;
		}
		
		public string ToString() 
		{
			return message;
		}		
	}
}