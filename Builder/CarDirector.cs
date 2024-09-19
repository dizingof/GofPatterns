public class CarDirector
{
    public Car Build(ICarBuilder carBuilder)
    {
        carBuilder.SetEngine();
        carBuilder.SetDoors();
        carBuilder.SetColor();
        return carBuilder.GetCar();
    }
}