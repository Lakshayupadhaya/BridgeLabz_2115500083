using System;

public class BMICalculator
{
    // Method to calculate BMI
    public static double CalculateBMI(double weight, double height)
    {
        height = height / 100; // Convert height from cm to meters
        return weight / (height * height); // BMI formula
    }

    // Method to determine BMI status
    public static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi < 24.9) return "Normal weight";
        else if (bmi < 29.9) return "Overweight";
        else return "Obese";
    }

    // Main method
    public static void Main(string[] args)
    {
        double[,] data = new double[10, 3]; // Array to store weight, height, and BMI for 10 people

        // Taking input for weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
            data[i, 0] = double.Parse(Console.ReadLine()); // weight
            Console.Write("Enter height (cm) for person " + (i + 1) + ": ");
            data[i, 1] = double.Parse(Console.ReadLine()); // height

            // Calculate BMI and store it in the array
            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
        }

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tWeight (kg)\tHeight (cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++)
        {
            string status = GetBMIStatus(data[i, 2]);
            Console.WriteLine((i + 1) + "\t" + data[i, 0] + "\t\t" + data[i, 1] + "\t\t" + data[i, 2].ToString("F2") + "\t" + status);
        }
    }
}
