using System;

public class RandomNumberStats
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // Generates a 4-digit random number
        }

        return randomNumbers;
    }

    // Method to find average, min, and max value of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }

        double average = sum / numbers.Length;

        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        // Generate 5 random 4-digit numbers
        int[] randomNumbers = Generate4DigitRandomArray(5);

        // Print the generated random numbers
        Console.WriteLine("Generated Random Numbers: ");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        // Find the average, min, and max of the numbers
        double[] results = FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Average: " + results[0].ToString("F2"));
        Console.WriteLine("Minimum: " + results[1]);
	}
}