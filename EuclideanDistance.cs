using System;

public class EuclideanDistance
{
    // Method to find the Euclidean distance between two points (x1, y1) and (x2, y2)
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        // Euclidean distance formula: distance = sqrt((x2 - x1)^2 + (y2 - y1)^2)
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of the line (slope m and y-intercept b)
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        // Check to avoid division by zero (vertical line case)
        if (x2 - x1 == 0)
        {
            throw new InvalidOperationException("The line is vertical, and the slope is undefined.");
        }

        // Calculate slope (m) and y-intercept (b)
        double slope = (y2 - y1) / (x2 - x1);  // m = (y2 - y1) / (x2 - x1)
        double yIntercept = y1 - slope * x1;   // b = y1 - m * x1

        return new double[] { slope, yIntercept };
    }

    public static void Main()
    {
        // Get input for the two points (x1, y1) and (x2, y2)
        Console.WriteLine("Enter coordinates of the first point (x1, y1):");
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coordinates of the second point (x2, y2):");
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean distance between the points: " + distance);

        // Find the equation of the line
        try
        {
            double[] lineEquation = FindLineEquation(x1, y1, x2, y2);
            Console.WriteLine("Equation of the line: y = " + lineEquation[0] + "x + " + lineEquation[1]);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // Handle the case for vertical lines
        }
    }
}
