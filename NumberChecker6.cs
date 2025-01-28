using System;

public class NumberChecker6
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        
        // Counting the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        
        int[] factors = new int[count];
        int index = 0;
        
        // Storing the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to find the greatest factor of a number
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1];  // The greatest factor is the last element in the sorted factors array
    }

    // Method to find the sum of the factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (var factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static int FindProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (var factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cubes of the factors
    public static double FindProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (var factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int sumOfFactors = 0;
        int[] factors = FindFactors(number);
        foreach (var factor in factors)
        {
            if (factor != number) // Exclude the number itself
            {
                sumOfFactors += factor;
            }
        }
        return sumOfFactors == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int sumOfFactors = 0;
        int[] factors = FindFactors(number);
        foreach (var factor in factors)
        {
            if (factor != number) // Exclude the number itself
            {
                sumOfFactors += factor;
            }
        }
        return sumOfFactors > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int sumOfFactors = 0;
        int[] factors = FindFactors(number);
        foreach (var factor in factors)
        {
            if (factor != number) // Exclude the number itself
            {
                sumOfFactors += factor;
            }
        }
        return sumOfFactors < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sumOfFactorials = 0;
        int temp = number;
        
        // Calculating the factorial of each digit and adding it
        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }
        
        return sumOfFactorials == number;
    }

    // Helper method to calculate factorial
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        int fact = 1;
        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    public static void Main()
    {
        int number = 145;  // Example number

        // Find factors of the number
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Find the greatest factor
        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));

        // Find the sum of the factors
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));

        // Find the product of the factors
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));

        // Find the product of the cubes of the factors
        Console.WriteLine("Product of Cubes of Factors: " + FindProductOfCubeOfFactors(factors));

        // Check if the number is a perfect number
        Console.WriteLine("Is Perfect Number: " + (IsPerfectNumber(number) ? "Yes" : "No"));

        // Check if the number is an abundant number
        Console.WriteLine("Is Abundant Number: " + (IsAbundantNumber(number) ? "Yes" : "No"));

        // Check if the number is a deficient number
        Console.WriteLine("Is Deficient Number: " + (IsDeficientNumber(number) ? "Yes" : "No"));

        // Check if the number is a strong number
        Console.WriteLine("Is Strong Number: " + (IsStrongNumber(number) ? "Yes" : "No"));
    }
}
