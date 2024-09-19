using AbstractFactory.Details;

public class CarBody : IBody
{
    public void CreateBody()
    {
        Console.WriteLine("Car body created.");
    }
}