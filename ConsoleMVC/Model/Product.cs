namespace ConsoleMVC.Model
{
	public class Product
	{
		public int Code { get; private set; }        
		public string Name { get; private set; }
		public float Price { get; private set; }

		private const string PATH = "Database/Products.csv";
		
		public Product()
		{
			string directory = PATH.Split("/")[0];
			if(!Directory.Exists(directory)) 
			{
				Directory.CreateDirectory(directory);
			}
			
			if(!File.Exists(PATH)) 
			{
				File.Create(PATH);
			}
		}
		
		public Product(int code, string name, float price)
		{
			this.Code = code;
			this.Name = name;
			this.Price = price;
		}
		
		public static void Create(Product product)
		{
			File.AppendAllText(PATH, $"{product.Code};{product.Name};{product.Price}");
		}
		
		public static List<Product> Read() 
		{
			List<Product> products = new List<Product>();
			
			string[] lines = File.ReadAllLines(PATH);

			foreach(string line in lines) 
			{
				string[] attributes = line.Split(";");
				
				int code = int.Parse(attributes[0]);
				string name = attributes[1];
				float price = float.Parse(attributes[2]); 	 
				
				products.Add(new Product(code, name, price));
			}
			
			return products;
		}
		
		public static void Update(Product product, int previousCode) 
		{
			Delete(previousCode);
			Create(product);
		}
		
		public static void Delete(int code) 
		{
			string tempFilePath = Path.GetTempFileName();
			var linesToKeep = File.ReadLines(PATH).Where(line => int.Parse(line.Split(";")[0]) != code);

			File.WriteAllLines(tempFilePath, linesToKeep);
			
			File.Delete(PATH);
			File.Move(tempFilePath, PATH);
		}
	}
}