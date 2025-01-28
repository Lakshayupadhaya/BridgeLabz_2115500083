using System;

class UnitConverter
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Convert Kilometers to Miles
        double km = 10;
        double miles = UnitConverter.ConvertKmToMiles(km);
        Console.WriteLine(km + " kilometers is equal to " + miles + " miles.");

        // Convert Miles to Kilometers
        double milesInput = 6.21;
        double kmConverted = UnitConverter.ConvertMilesToKm(milesInput);
        Console.WriteLine(milesInput + " miles is equal to " + kmConverted + " kilometers.");

        // Convert Meters to Feet
        double meters = 100;
        double feet = UnitConverter.ConvertMetersToFeet(meters);
        Console.WriteLine(meters + " meters is equal to " + feet + " feet.");

        // Convert Feet to Meters
        double feetInput = 328;
        double metersConverted = UnitConverter.ConvertFeetToMeters(feetInput);
        Console.WriteLine(feetInput + " feet is equal to " + metersConverted + " meters.");
    }
}
