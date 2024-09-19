using AbstractFactory.Details;

public class CarFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new CarEngine();
    }

    public IBody CreateBody()
    {
        return new CarBody();
    }
}