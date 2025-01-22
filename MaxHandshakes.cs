using System;

class MaxHandshakes
{
    static void Main()
    {
        // input no of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // works only if students are greater thatn 1
        if (numberOfStudents > 1)
        {
            // formula
            int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            // result
            Console.WriteLine("The maximum number of handshakes among {0} students is {1}.", 
                              numberOfStudents, maximumHandshakes);
        }
		// when user enters less than 1 or 1
        else
        {
            Console.WriteLine("The number of students must be greater than 1 to have handshakes.");
        }
    }
}
