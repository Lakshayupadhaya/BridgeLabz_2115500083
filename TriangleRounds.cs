using System;

class TriangleRounds
{
    static void Main()
    {
        // input all three sides in metres
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Converting km to m
        double totalDistance = 5000;  // 5 km = 5000 meters

        // Calculate the number of rounds needed
        double rounds = totalDistance / perimeter;

        // result
        Console.WriteLine("The total number of rounds the athlete will run is {0:F2} to complete 5 km.", rounds);
    }
}
