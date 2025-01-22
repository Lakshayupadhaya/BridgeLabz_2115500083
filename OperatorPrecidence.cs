using System;

class OperatorPrecidence
{
    static void Main()
    {
        // input values from user
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // operations
        int result1 = a + b * c;    // Multiplication (*) is performed before addition (+)
        int result2 = a * b + c;    // Multiplication (*) is performed before addition (+)
        int result3 = c + a / b;    // Division (/) is performed before addition (+)
        int result4 = a % b + c;    // Modulus (%) is performed before addition (+)
		
		Console.WriteLine("The results of Int Operations are {0}, {1}, {2} and {3}", result1, result2, result3, result4);
	}
}
		
		