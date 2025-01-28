using System;

public class QuadraticEquation
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        // Calculate the discriminant (delta)
        double delta = Math.Pow(b, 2) - 4 * a * c;

        // If delta is positive, two real roots exist
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a); // First root
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a); // Second root
            return new double[] { root1, root2 };
        }
        // If delta is zero, only one real root exists
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        // If delta is negative, there are no real roots
        else
        {
            return new double[0]; // No real roots
        }
    }

    public static void Main(string[] args)
    {
        // Take input for a, b, and c
        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Get the roots of the quadratic equation
        double[] roots = FindRoots(a, b, c);

        // Display the result
        if (roots.Length == 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("There is one real root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The roots of the equation are: ");
            Console.WriteLine("Root 1: " + roots[0]);
            Console.WriteLine("Root 2: " + roots[1]);
        }
    }
}
