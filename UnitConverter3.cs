using System;

class UnitConverter3
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Convert Fahrenheit to Celsius
        double fahrenheit = 100;
        double celsius = UnitConverter3.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + "°F is equal to " + celsius + "°C.");

        // Convert Celsius to Fahrenheit
        double celsiusInput = 37.5;
        double fahrenheitConverted = UnitConverter3.ConvertCelsiusToFahrenheit(celsiusInput);
        Console.WriteLine(celsiusInput + "°C is equal to " + fahrenheitConverted + "°F.");

        // Convert Pounds to Kilograms
        double pounds = 150;
        double kilograms = UnitConverter3.ConvertPoundsToKilograms(pounds);
        Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms.");

        // Convert Kilograms to Pounds
        double kilogramsInput = 68;
        double poundsConverted = UnitConverter3.ConvertKilogramsToPounds(kilogramsInput);
        Console.WriteLine(kilogramsInput + " kilograms is equal to " + poundsConverted + " pounds.");

        // Convert Gallons to Liters
        double gallons = 5;
        double liters = UnitConverter3.ConvertGallonsToLiters(gallons);
        Console.WriteLine(gallons + " gallons is equal to " + liters + " liters.");

        // Convert Liters to Gallons
        double litersInput = 20;
        double gallonsConverted = UnitConverter3.ConvertLitersToGallons(litersInput);
        Console.WriteLine(litersInput + " liters is equal to " + gallonsConverted + " gallons.");
    }
}
