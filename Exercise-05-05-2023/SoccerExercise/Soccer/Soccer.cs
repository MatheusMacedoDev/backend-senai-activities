using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerExercise.Soccer
{
	public abstract class Soccer
	{
		private string name;
		private string nationality;
		private DateTime birth;
		private float weight;
		
		public Soccer(string name, string nationality, DateTime birth, float weight) 
		{
			this.name = name;
			this.nationality = nationality;
			this.birth = birth;
			this.weight = weight;
		}
		
		public int SoccerAge() 
		{
			return DateTime.Now.Year - birth.Year;
		}
		
		public abstract int yearsForAposentar();
	}
}