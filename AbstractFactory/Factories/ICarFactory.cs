using AbstractFactory.Details;

public interface ICarFactory
{
    IEngine CreateEngine();
    IBody CreateBody();
}
