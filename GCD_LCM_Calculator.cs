using System;

class GCD_LCM_Calculator
{
    //method to calculate gcd it also be done using recursion
	static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
	// function to calculate lcm using the formula
    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);// formula to calculate lcm using gcd
    }
	//function to display result
	static void DisplayResult(int gcd, int lcm)
	{
		Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
	}

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        num1 = Math.Abs(num1);//using absolute method to make sure value is +ve
        num2 = Math.Abs(num2);

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        DisplayResult(gcd, lcm);
    }
}
