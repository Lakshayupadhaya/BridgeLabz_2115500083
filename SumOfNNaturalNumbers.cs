using System;

class SumOfNNaturalNumbers
{
    static void Main()
    {
        // Input a number
        Console.Write("Enter a number: ");
        // string because user can input any value and to try parse
		string input = Console.ReadLine();

        // Check if the input is a valid natural number
        int number;
        if (int.TryParse(input, out number) && number >= 0)
        {
            // Calculate the sum of the first n natural numbers
            int sum = number * (number + 1) / 2;

            // Output the result
            Console.WriteLine("The sum of {0} natural numbers is {1}", number, sum);
        }
        else
        {
            // If the input is not a valid natural number
            Console.WriteLine("The number {0} is not a natural number", input);
        }
    }
}
