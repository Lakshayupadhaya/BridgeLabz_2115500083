using System;

class QuotientAndRemainder
{
    static void Main()
    {
        // input two nummbers from user
        Console.Write("Enter the first number (dividend): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (divisor): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // check if the second number is not zero
        if (number2 != 0)
        {
            // Calculate the quotient and remainder
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            // result
            Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}.", 
                              quotient, remainder, number1, number2);
        }
        // for the Denominator == zero
		else
        {

            Console.WriteLine("Division by zero is not allowed. Please enter a valid divisor.");
        }
    }
}
