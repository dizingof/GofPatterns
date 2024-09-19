CarDirector director = new CarDirector();

ICarBuilder sportsCarBuilder = new SportsCarBuilder();
Car sportsCar = director.Build(sportsCarBuilder);
Console.WriteLine("Sports Car Specifications:");
sportsCar.ShowSpecifications();

Console.WriteLine();

ICarBuilder suvCarBuilder = new SuvCarBuilder();
Car suvCar = director.Build(suvCarBuilder);
Console.WriteLine("SUV Car Specifications:");
suvCar.ShowSpecifications();

Console.ReadLine();