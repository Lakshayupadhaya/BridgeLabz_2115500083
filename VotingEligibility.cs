using System;

class VotingEligibility
{
    static void Main()
    {
        // Input the person's age
        Console.Write("Enter the person's age: ");
        int age;

        // Validate the input given by user
        try
        {
            age = Convert.ToInt32(Console.ReadLine());

            // Check voting eligibility
            if (age >= 18)
            {
                Console.WriteLine("The person's age is {0} and can vote.", age);
            }
            else
            {
                Console.WriteLine("The person's age is {1} and cannot vote.", age);
            }
        }
        catch (Exception e)
        {
            // If input is not a valid integer
            Console.WriteLine(e.Message);
        }
    }
}
