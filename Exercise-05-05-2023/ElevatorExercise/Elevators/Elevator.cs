using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ElevatorExercise.Elevators.Exceptions;

namespace ElevatorExercise.Elevators
{
	public class Elevator
	{
		public int CurrentFloor { get; private set; }
		public int CurrentPeopleQuantity { get; private set; }

		private int floorsQuantity;
		private int maxPeopleQuantity;
		
		public Elevator(int floorsQuantity, int maxPeopleQuantity) 
		{
			this.CurrentFloor = 0;
			this.CurrentPeopleQuantity = 0;
			
			this.floorsQuantity = floorsQuantity;
			this.maxPeopleQuantity = maxPeopleQuantity;
		}
		
		public void enter() 
		{
			if (CurrentPeopleQuantity < maxPeopleQuantity) 
			{
				CurrentPeopleQuantity++;
			}
			else 
			{
				throw new LotOfPeopleException("The elevator is full");
			}
		}
		
		public void exit() 
		{
			if (CurrentPeopleQuantity > 0) 
			{
				CurrentPeopleQuantity--;
			}
			else 
			{
				Console.WriteLine($"Have no people in the elevator");
			}
		}
		
		public void stepUp() 
		{
			if (CurrentFloor < floorsQuantity) 
			{
				CurrentFloor++;
			}
			else 
			{
				Console.WriteLine($"You are in the top. You can not step up more.");
			}
		}
		
		public void stepDown() 
		{
			if (CurrentFloor > 0) 
			{
				CurrentFloor--;
			}
			else 
			{
				Console.WriteLine($"You are in the ground. You can not step down more.");
				
			}
		}
	}
}