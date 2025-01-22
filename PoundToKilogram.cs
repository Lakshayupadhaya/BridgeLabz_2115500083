using System;

class PoundToKilogram
{
    static void Main()
    {
        // input the weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms 
        double weightInKilograms = weightInPounds / 2.2; // 1kg = 2.2 pound

        // Display the result
        Console.WriteLine("The weight of the person in pounds is {0:F2} and in kg is {1:F2}.", weightInPounds, weightInKilograms);
    }
}
