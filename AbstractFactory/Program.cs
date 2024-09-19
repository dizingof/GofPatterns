using AbstractFactory.Details;

ICarFactory carFactory = new CarFactory();
IEngine carEngine = carFactory.CreateEngine();
IBody carBody = carFactory.CreateBody();

carEngine.Start();
carBody.CreateBody();

Console.WriteLine();

ICarFactory truckFactory = new TruckFactory();
IEngine truckEngine = truckFactory.CreateEngine();
IBody truckBody = truckFactory.CreateBody();

truckEngine.Start();
truckBody.CreateBody();
