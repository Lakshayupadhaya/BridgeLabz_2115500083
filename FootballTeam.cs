using System;

public class FootballTeam
{
    // Method to generate random heights for players
    public static int[] GenerateRandomHeights(int size)
    {
        Random random = new Random();
        int[] heights = new int[size];

        // Generate random heights between 150 and 250 cm
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251); // Generates a random number between 150 and 250
        }

        return heights;
    }

    // Method to find the sum of the heights in the array
    public static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height of the players
    public static double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height in the array
    public static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height in the array
    public static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }

    public static void Main(string[] args)
    {
        // Generate heights for 11 players
        int[] heights = GenerateRandomHeights(11);

        // Display the generated heights
        Console.WriteLine("Generated Heights of 11 Players (in cms):");
        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }

        // Find the shortest, tallest, and mean height
        int shortestHeight = FindShortestHeight(heights);
        int tallestHeight = FindTallestHeight(heights);
        double meanHeight = FindMeanHeight(heights);

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Shortest Height: " + shortestHeight + " cm");
        Console.WriteLine("Tallest Height: " + tallestHeight + " cm");
        Console.WriteLine("Mean Height: " + meanHeight.ToString("F2") + " cm");
    }
}
