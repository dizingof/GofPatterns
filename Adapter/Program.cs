ICelsiusTemperature celsiusTemp = new CelsiusTemperature(25);

IFahrenheitTemperature fahrenheitTemp = new TemperatureAdapter(celsiusTemp);

Console.WriteLine("Температура в Цельсиях: " + celsiusTemp.GetTemperatureCelsius());
Console.WriteLine("Температура в Фаренгейтах: " + fahrenheitTemp.GetTemperatureFahrenheit());