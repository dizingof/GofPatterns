public class TemperatureAdapter : IFahrenheitTemperature
{
    private readonly ICelsiusTemperature celsiusTemperature;

    public TemperatureAdapter(ICelsiusTemperature celsiusTemperature)
    {
        this.celsiusTemperature = celsiusTemperature;
    }

    public double GetTemperatureFahrenheit()
    {
        double celsius = celsiusTemperature.GetTemperatureCelsius();
        return (celsius * 9 / 5) + 32;
    }
}