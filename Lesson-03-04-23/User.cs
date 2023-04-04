namespace Application 
{
	public class User 
	{
		private int id;
		private string name;
		private string email;
		
		public User(int id, string name, string email) 
		{
			this.id = id;
			this.name = name;
			this.email = email;
		}
		
		public string ToString() 
		{
			return $"This user is {name}, his id is {id} and his e-mail is {email}.";
		}
	}
}