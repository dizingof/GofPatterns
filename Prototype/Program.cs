Car originalCar = new Car("Tesla Model S", "Red", 670);
Console.WriteLine("Original Car:");
originalCar.ShowDetails();

Car clonedCar = originalCar.Clone();
clonedCar.Color = "Blue"; /
Console.WriteLine("\nCloned Car:");
clonedCar.ShowDetails();

Console.ReadLine();