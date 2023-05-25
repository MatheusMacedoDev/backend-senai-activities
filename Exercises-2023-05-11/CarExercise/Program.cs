using CarExercise;

LinkedList<Car> cars = new LinkedList<Car>(); 

for (int i = 1; i <= 2; i++) 
{
	Console.WriteLine($"Type the car {i} information:");
	Console.WriteLine($"Brand: ");
	string brand = Console.ReadLine();
	
	Console.WriteLine($"Color: ");
	string color = Console.ReadLine();
	
	Car car = new Car(brand, color);
	cars.AddLast(car);
}

Console.WriteLine($"");
Console.WriteLine($"Cars: ");

foreach(Car car in cars) 
{
	Console.WriteLine($"The car have a brand {car.Brand} and a color {car.Color}");
}