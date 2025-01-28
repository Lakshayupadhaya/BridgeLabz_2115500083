using System;

class Wind
{
    // Method to calculate the wind chill temperature
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        // Wind chill formula
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        return windChill;
    }

    static void Main(string[] args)
    {
        // Take input for temperature and wind speed
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Calling the method
		Wind run = new Wind();
        double windChill = run.CalculateWindChill(temperature, windSpeed);

        // result
        Console.WriteLine("The wind chill temperature is: {0} DegreeF", windChill);
    }
}
