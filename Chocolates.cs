using System;

class Chocolates
{
    // Method to find the quotient (chocolates per child) and remainder (remaining chocolates)
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int[] result = new int[2]; // Array to store quotient and remainder
        result[0] = number / divisor; // Quotient (chocolates per child)
        result[1] = number % divisor; // Remainder (remaining chocolates)
        return result;
    }

    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Check if the number of children is not zero
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Sorry this cannot be called for zero number of students");
            return;
        }

        // Call the method to find quotient and remainder
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // results
        Console.WriteLine("Each child will get: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates are: " + result[1]);
    }
}
