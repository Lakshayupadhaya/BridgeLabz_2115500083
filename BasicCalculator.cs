using System;

class BasicCalculator
{
    // Function for addition
    static double Add(double num1, double num2)
    {
        return num1 + num2; // Return sum
    }

    // Function for subtraction
    static double Subtract(double num1, double num2)
    {
        return num1 - num2; // Return difference
    }

    // Function for multiplication
    static double Multiply(double num1, double num2)
    {
        return num1 * num2; // Return product
    }

    // Function for division
    static double Divide(double num1, double num2)
    {
        //Handeling zero division
		if (num2 == 0) 
        {
            Console.WriteLine("Error: Division by zero is not allowed!");
            return 0; 
        }
        return num1 / num2; // Return quotient
    }

    static void Main()
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.Write("Choose an operation (1-4): ");
        //Takinf user input and choice 
        int choice = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); 

        double result = 0; // variable yo store the result

        // To check the choice and preform based on choice
        if (choice == 1)
        {
            result = Add(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (choice == 2)
        {
            result = Subtract(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (choice == 3)
        {
            result = Multiply(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (choice == 4)
        {
            result = Divide(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Invalid choice! Please select a number between 1 and 4.");
        }
    }
}
