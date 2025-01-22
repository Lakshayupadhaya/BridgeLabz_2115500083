using System;

class TotalPrice
{
    static void Main()
    {
        // input in INR and quantity
        Console.Write("Enter the unit price of the item in INR: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
		
        Console.Write("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total purchase price
        double totalPrice = unitPrice * quantity;

        // Display the total price with details
        Console.WriteLine("The total purchase price is INR {0:F2} if the quantity is {1} and unit price is INR {2:F2}.", 
                          totalPrice, quantity, unitPrice);
    }
}
