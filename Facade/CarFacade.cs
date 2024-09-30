public class CarFacade
{
    private Engine _engine;
    private Transmission _transmission;
    private FuelSystem _fuelSystem;

    public CarFacade()
    {
        _engine = new Engine();
        _transmission = new Transmission();
        _fuelSystem = new FuelSystem();
    }

    public void StartCar()
    {
        Console.WriteLine("Запуск автомобиля...");
        _fuelSystem.SupplyFuel();
        _engine.Start();
        _transmission.SetGear(1);
        Console.WriteLine("Автомобиль запущен и готов к движению.");
    }

    public void StopCar()
    {
        Console.WriteLine("Остановка автомобиля...");
        _engine.Stop();
        _transmission.SetGear(0);
        Console.WriteLine("Автомобиль остановлен.");
    }
}