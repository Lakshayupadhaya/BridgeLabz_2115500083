using System;

class TotalIncome
{
    static void Main()
    {
        // input salary and bonus from user
        Console.Write("Enter the salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // total income
        double totalIncome = salary + bonus;

        // result
        Console.WriteLine("The salary is INR {0:F2} and bonus is INR {1:F2}. Hence Total Income is INR {2:F2}.", salary, bonus, totalIncome);
    }
}
