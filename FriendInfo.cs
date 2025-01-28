using System;

public class FriendInfo
{
    // Method to find the youngest among the three friends
    public static string FindYoungest(int age1, int age2, int age3)
    {
        if (age1 <= age2 && age1 <= age3) return "Amar";
        if (age2 <= age1 && age2 <= age3) return "Akbar";
        return "Anthony";
    }

    // Method to find the tallest among the three friends
    public static string FindTallest(double height1, double height2, double height3)
    {
        if (height1 >= height2 && height1 >= height3) return "Amar";
        if (height2 >= height1 && height2 >= height3) return "Akbar";
        return "Anthony";
    }

    public static void Main(string[] args)
    {
        // Input age and height for each friend
        Console.Write("Enter Amar's age: ");
        int age1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height (in meters): ");
        double height1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int age2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height (in meters): ");
        double height2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int age3 = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height (in meters): ");
        double height3 = double.Parse(Console.ReadLine());

        // Find and display the youngest friend
        Console.WriteLine(FindYoungest(age1, age2, age3) + " is the youngest friend.");

        // Find and display the tallest friend
        Console.WriteLine(FindTallest(height1, height2, height3) + " is the tallest friend.");
    }
}
