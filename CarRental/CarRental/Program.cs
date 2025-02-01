using System;

class CarRental 
{
    //attributes of car renting class
    private string customerName;
    private string carModel;
    private int rentalDays;
    private int totalCost;
    private  int costPerday = 1700;//cost per day for rental total cost

    static CarRental() 
    {
        Console.WriteLine("Rental cost for 24 hours is 1700");//prints what is the price of rent for 24 hrs in the very start
    }
    // constructor for initializing values and calculate total cost and then store it
    public CarRental(string customerName,  string carModel, int rentalDays) 
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.totalCost = costPerday * this.rentalDays;
    }

    static void Main() 
    {
        CarRental car1 = new CarRental("Lakshay", "Virtus", 8);//creating instance of class 
        Console.WriteLine(car1.customerName + " " + car1.carModel + " " + car1.rentalDays + " " + car1.totalCost);//display output
    }

}