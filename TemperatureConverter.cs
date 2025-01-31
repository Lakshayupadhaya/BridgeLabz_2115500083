using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9; // Formula: (F - 32) * 5/9
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32; // Formula: (C * 9/5) + 32
    }

    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
		double fahrenheit = Convert.ToDouble(Console.ReadLine());
		double celsiusResult = FahrenheitToCelsius(fahrenheit); // celsius to fahrenheit
		Console.WriteLine("Temperature in Celsius: " + celsiusResult);      
    
        Console.Write("Enter temperature in Celsius: ");
		double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheitResult = CelsiusToFahrenheit(celsius); // fahrenheit to celsius
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheitResult);
    }

}
