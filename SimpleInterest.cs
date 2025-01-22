using System;

class SimpleInterest
{
    static void Main()
    {
        // input the Principal value
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // input the Rate of Interest
        Console.Write("Enter the Rate of Interest in %: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // input the Time period
        Console.Write("Enter the Time period in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest using the formula
        double simpleInterest = (principal * rate * time) / 100;

        // result
        Console.WriteLine("The Simple Interest is {0:F2} for Principal {1:F2}, Rate of Interest {2:F2}, and Time {3:F2} years.", simpleInterest, principal, rate, time);
    }
}
