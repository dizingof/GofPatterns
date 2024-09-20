public class CelsiusTemperature : ICelsiusTemperature
{
    private double temperature;

    public CelsiusTemperature(double temperature)
    {
        this.temperature = temperature;
    }

    public double GetTemperatureCelsius()
    {
        return temperature;
    }
}