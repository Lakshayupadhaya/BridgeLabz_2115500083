using System;

class DivsionQuesAndRemain
{
    // Method to find the quotient and remainder of two numbers
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int[] result = new int[2]; // Array to store quotient and remainder
        result[0] = number / divisor; // Quotient
        result[1] = number % divisor; // Remainder
        return result;
    }

    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter the first number (dividend): ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (divisor): ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Check if the divisor is not zero
        if (divisor == 0)
        {
            Console.WriteLine("Divison by zero is not possible yet");
            return;
        }

        // method call
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Display the results
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
}
