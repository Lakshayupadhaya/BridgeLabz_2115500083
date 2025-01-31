using System;

class FactorialProgram
{
    // Calculating factorial using recursion
    static int Factorial(int n)
    {
        if (n == 0) // Base case: factorial of 0 is 1
        {
            return 1;
        }
        return n * Factorial(n - 1); // Recursive call
    }

    // method to take user input and return the input
    static int GetNumberFromUser()
    {
        //taking input from user
		Console.Write("Enter a number: "); 
        int num = Convert.ToInt32(Console.ReadLine()); 
        return num;
    }

    // Function to display the resu;t
    static void DisplayResult(int number, int fact)
    {
        Console.WriteLine("Factorial of " + number + " is: " + fact); 
    }

    static void Main()
    {
        int num = GetNumberFromUser(); // Get number from user
        int result = Factorial(num); // Call factorial function
        DisplayResult(num, result); // Show result
    }
}
