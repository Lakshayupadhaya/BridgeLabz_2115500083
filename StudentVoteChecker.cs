using System;

public class StudentVoteChecker
{
    // Method to check if the student can vote based on their age
    public bool CanStudentVote(int age)
    {
        // Validate the age input
        if (age < 0)
        {
            // if age is negative
            return false;
        }

        // If age is 18 or greater, return true  else return false 
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Main method to take input and check for voting eligibility
    public static void Main(string[] args)
    {
        // Array to store the ages of 10 students
        int[] studentAges = new int[10];

        // Create an instance of StudentVoteChecker class
        StudentVoteChecker checker = new StudentVoteChecker();

        // Loop to get the ages of 10 students
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age for student " + (i + 1) + ": ");
            // Read input and store it in the array
            studentAges[i] = int.Parse(Console.ReadLine());

            // Call CanStudentVote method and display result
            if (checker.CanStudentVote(studentAges[i]))
            {
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
            }
        }
    }
}
