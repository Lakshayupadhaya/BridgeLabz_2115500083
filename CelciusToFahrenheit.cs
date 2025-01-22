using System;

class CelciusToFahrenheit
{
    static void Main()
    {
        // input in celsius from user
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // result
        Console.WriteLine("The {0:F2} Celsius is {1:F2} Fahrenheit.", celsius, fahrenheitResult);
    }
}
