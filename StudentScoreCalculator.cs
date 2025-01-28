using System;

public class StudentScoreCalculator
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Maths for each student
    public static double[,] GenerateStudentScores(int numStudents)
    {
        Random random = new Random();
        double[,] scores = new double[numStudents, 3]; // Columns for Physics, Chemistry, and Maths

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = random.Next(50, 101); // Random score for Physics between 50 and 100
            scores[i, 1] = random.Next(50, 101); // Random score for Chemistry between 50 and 100
            scores[i, 2] = random.Next(50, 101); // Random score for Maths between 50 and 100
        }

        return scores;
    }

    // Method to calculate the total, average, and percentage for each student
    public static double[,] CalculateTotalsAveragesPercentages(double[,] scores, int numStudents)
    {
        double[,] results = new double[numStudents, 4]; // Columns for Total, Average, Percentage, and Extra Space

        for (int i = 0; i < numStudents; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2]; // Calculate total marks
            double average = total / 3; // Calculate average
            double percentage = (total / 300) * 100; // Calculate percentage (out of 300)

            // Store results rounded to 2 decimal places
            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    // Method to display the scorecard of all students in a tabular format
    public static void DisplayScorecard(double[,] scores, double[,] results, int numStudents)
    {
        Console.WriteLine("Student Scorecard");
        //Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        //Console.WriteLine("---------------------------------------------------");

        for (int i = 0; i < numStudents; i++)
        {
            // Displaying the scores and calculated results
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                i + 1, // Student number
                scores[i, 0], // Physics score
                scores[i, 1], // Chemistry score
                scores[i, 2], // Maths score
                results[i, 0], // Total
                results[i, 1], // Average
                results[i, 2]); // Percentage
        }

        //Console.WriteLine("---------------------------------------------------");
    }

    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine()); // Take input for the number of students

        // Step 1: Generate random scores for each student
        double[,] scores = GenerateStudentScores(numStudents);

        // Step 2: Calculate total, average, and percentage for each student
        double[,] results = CalculateTotalsAveragesPercentages(scores, numStudents);

        // Step 3: Display the scorecard of all students
        DisplayScorecard(scores, results, numStudents);
    }
}
