using System;

public class CollinearPoints
{
    // Method to check if points are collinear using slope formula
    public static bool AreCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate slopes AB and BC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        
        // Points are collinear if slopes AB and BC are equal
        return slopeAB == slopeBC;
    }

    // Method to check if points are collinear using area of triangle formula
    public static bool AreCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate area of triangle formed by points (x1, y1), (x2, y2), (x3, y3)
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        
        // Points are collinear if area is zero
        return area == 0;
    }

    public static void Main()
    {
        // Taking input for the three points A, B, and C
        Console.WriteLine("Enter coordinates for Point A (x1, y1):");
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coordinates for Point B (x2, y2):");
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter coordinates for Point C (x3, y3):");
        Console.Write("x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check if points are collinear using slope method
        bool collinearUsingSlope = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        // Check if points are collinear using area method
        bool collinearUsingArea = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        // Output the results
        if (collinearUsingSlope && collinearUsingArea)
        {
            Console.WriteLine("The points are collinear.");
        }
        else
        {
            Console.WriteLine("The points are not collinear.");
        }
    }
}
