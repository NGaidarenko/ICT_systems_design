using System;

interface ITemperatureConverter
{
    public static int ConvertToCelsius(int tempFahrenheit)
    {
        return tempFahrenheit;
    }
}

class TemperatureDisplay
{
    public int TemperatureCelsius;
    public void ShowTemperature()
    {
        Console.WriteLine($"Температура: {TemperatureCelsius}°C");
    }
}

class FahrenheitToCelsiusAdapter : ITemperatureConverter
{
    public static int ConvertToCelsius(int tempFahrenheit)
    {
        int tempCelsius = (tempFahrenheit - 32) * 5 / 9;
        return tempCelsius;
    }
}

class Adapter
{
    static void Main()
    {
        TemperatureDisplay display = new TemperatureDisplay();
        display.TemperatureCelsius = FahrenheitToCelsiusAdapter.ConvertToCelsius(32);
        display.ShowTemperature();
    }
}