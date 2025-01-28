using System;

public class ZaraBonusCalculator
{
    // Method to generate random salary and years of service for 10 employees
    public static double[,] GenerateEmployeeData(int size)
    {
        double[,] employeeData = new double[size, 2]; // First column for salary, second for years of service
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            employeeData[i, 0] = random.Next(10000, 99999); // Random salary between 10,000 and 99,999
            employeeData[i, 1] = random.Next(1, 21); // Random years of service between 1 and 20
        }

        return employeeData;
    }

    // Method to calculate new salary and bonus for each employee
    public static double[,] CalculateNewSalariesAndBonuses(double[,] employeeData, int size)
    {
        double[,] updatedData = new double[size, 3]; // First column for old salary, second for new salary, third for bonus

        for (int i = 0; i < size; i++)
        {
            double oldSalary = employeeData[i, 0];
            int yearsOfService = (int)employeeData[i, 1];
            double bonus = 0;

            // Determine the bonus based on years of service
            if (yearsOfService > 5)
            {
                bonus = oldSalary * 0.05; // 5% bonus for more than 5 years of service
            }
            else
            {
                bonus = oldSalary * 0.02; // 2% bonus for less than or equal to 5 years of service
            }

            double newSalary = oldSalary + bonus;
            
            // Save old salary, new salary and bonus to updatedData
            updatedData[i, 0] = oldSalary;
            updatedData[i, 1] = newSalary;
            updatedData[i, 2] = bonus;
        }

        return updatedData;
    }

    // Method to calculate the total sums for old salary, new salary, and total bonus
    public static void CalculateTotalSums(double[,] updatedData, int size)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < size; i++)
        {
            totalOldSalary += updatedData[i, 0];
            totalNewSalary += updatedData[i, 1];
            totalBonus += updatedData[i, 2];
        }

        // Display the results in tabular format
        Console.WriteLine("\nEmployee Salary and Bonus Details:");
        //Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-10}", "Employee", "Old Salary", "New Salary", "Bonus");
        //Console.WriteLine("---------------------------------------------------");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0,-10} {1,-15:C} {2,-15:C} {3,-10:C}", i + 1, updatedData[i, 0], updatedData[i, 1], updatedData[i, 2]);
        }

        //Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("{0,-10} {1,-15:C} {2,-15:C} {3,-10:C}", "Total", totalOldSalary, totalNewSalary, totalBonus);
    }

    public static void Main()
    {
        int size = 10; // Number of employees

        // Step 1: Generate random salary and years of service for each employee
        double[,] employeeData = GenerateEmployeeData(size);

        // Step 2: Calculate the new salary and bonus for each employee
        double[,] updatedData = CalculateNewSalariesAndBonuses(employeeData, size);

        // Step 3: Calculate total old salary, new salary, and total bonus, and display in tabular format
        CalculateTotalSums(updatedData, size);
    }
}
