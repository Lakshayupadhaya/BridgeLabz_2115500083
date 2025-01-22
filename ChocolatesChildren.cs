using System;

class ChocolatesChildren
{
    static void Main()
    {
        // input no of chocolates
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // input the number of children
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate the number of chocolates each child gets
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;

        // Calculate the number of remaining chocolates
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Display the result
        Console.WriteLine("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}.", chocolatesPerChild, remainingChocolates);
    }
}
