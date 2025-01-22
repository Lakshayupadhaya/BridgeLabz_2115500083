using System;

class SquareSide
{
    static void Main()
    {
        // input perimeter of square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        
		double side = perimeter / 4;

        //result
        Console.WriteLine("The length of the side is {0} whose perimeter is {1}.", side, perimeter);
    }
}
