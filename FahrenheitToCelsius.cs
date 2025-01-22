using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        // input 
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // result
        Console.WriteLine("The {0:F2} Fahrenheit is {1:F2} Celsius.", fahrenheit, celsiusResult);
    }
}
