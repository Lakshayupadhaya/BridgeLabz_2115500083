using System;

class Trigonometry
{
    // Method to calculate sine, cosine, and tangent of an angle
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert the angle from degrees to radians
        double radians = Math.PI * angle / 180.0;

        // Calculate trigonometric functions
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        // Take input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calling method
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results string concatination instead of string interpolation
        Console.WriteLine("Sine(" + angle + "°) = " + results[0].ToString("F4"));
        Console.WriteLine("Cosine(" + angle + "°) = " + results[1].ToString("F4"));
		Console.WriteLine("Tangent(" + angle + "°) = " + results[2].ToString("F4"));
		
    }
}
