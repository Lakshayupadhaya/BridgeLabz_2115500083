using System;

class AreaOfTriangle
{
    static void Main()
    {
        // Prompt the user to input the base of the triangle in cm
        Console.Write("Enter the base of the triangle in cm: ");
        double baseInCm = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the height of the triangle in cm
        Console.Write("Enter the height of the triangle in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle in square centimeters
        double areaInCm2 = 0.5 * baseInCm * heightInCm;

        // Convert the base and height to inches
        double baseInInches = baseInCm / 2.54;
        double heightInInches = heightInCm / 2.54;

        // Calculate the area in square inches
        double areaInInches2 = 0.5 * baseInInches * heightInInches;

        // Convert height in cm to feet and inches
        //int heightInFeet = (int)(heightInCm / 30.48); // 1 foot = 30.48 cm
        //double remainingInches = (heightInCm % 30.48) // 2.54;

        // Display the results
        Console.WriteLine("The area of the triangle is:");
        Console.WriteLine("  In square centimeters: {0:F2} cm²", areaInCm2);
        Console.WriteLine("  In square inches: {0:F2} in²", areaInInches2);
    }
}
