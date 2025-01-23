using System;

class Largest
{
    static void Main()
    {
        // Input three numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        double number3 = Convert.ToDouble(Console.ReadLine());

       

        // Output the results || number1 == number2 || number1 == number3 --> to check if to number are greatest in the input and same
        Console.WriteLine("Is the first number the largest? " + ((number1 > number2 && number1 > number3 || number1 == number2 || number1 == number3) ? "Yes" : "No"));  // Check which number is the largest in the line
        Console.WriteLine("Is the second number the largest? " + ((number2 > number1 && number2 > number3 || number2 == number1 || number2 == number3) ? "Yes" : "No"));  // Check which number is the largest in the line
        Console.WriteLine("Is the third number the largest? " + ((number3 > number1 && number3 > number2 || number3 == number1 || number3 == number2) ? "Yes" : "No"));  // Check which number is the largest in the line
    }
}
