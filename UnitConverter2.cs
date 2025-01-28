using System;

class UnitConverter2
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test cases to demonstrate the conversions

        // Convert Yards to Feet
        double yards = 5;
        double feet = UnitConverter2.ConvertYardsToFeet(yards);
        Console.WriteLine(yards + " yards is equal to " + feet + " feet.");

        // Convert Feet to Yards
        double feetInput = 15;
        double yardsConverted = UnitConverter2.ConvertFeetToYards(feetInput);
        Console.WriteLine(feetInput + " feet is equal to " + yardsConverted + " yards.");

        // Convert Meters to Inches
        double meters = 2;
        double inches = UnitConverter2.ConvertMetersToInches(meters);
        Console.WriteLine(meters + " meters is equal to " + inches + " inches.");

        // Convert Inches to Meters
        double inchesInput = 50;
        double metersConverted = UnitConverter2.ConvertInchesToMeters(inchesInput);
        Console.WriteLine(inchesInput + " inches is equal to " + metersConverted + " meters.");

        // Convert Inches to Centimeters
        double inchesForCm = 12;
        double cm = UnitConverter2.ConvertInchesToCentimeters(inchesForCm);
        Console.WriteLine(inchesForCm + " inches is equal to " + cm + " centimeters.");
    }
}
