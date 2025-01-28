using System;

class NumberFactors
{
    // Method to find the factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        // find the count of factors to declare array
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        //declaring size of array 
        int[] factors = new int[count];
        int index = 0;

        // Second loop: Save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to find the sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of factors
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the sum of the squares of factors
    public static double FindSumOfSquareOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a number to find its factors: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the method to find the factors
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));

        // Calculate and display the sum, product, and sum of squares of the factors
        int sum = FindSumOfFactors(factors);
        long product = FindProductOfFactors(factors);
        double sumOfSquares = FindSumOfSquareOfFactors(factors);

        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
