using System;
using System.Runtime.CompilerServices;

class Circle 
{
    // it is not accessed by any other class no modification outside class is allowed
    private double radius;

    public Circle() : this(10)// this  here calls the parameterised constructer first and then the default constructer works
    {
        Console.WriteLine("Default constructor is called");
        Console.WriteLine("default value of radius is 10");
        
    }

    public Circle(double radius)// Main working constructor here 
    {
        Console.WriteLine("Parameterized constructor is called");
        this.radius = radius;
    }

    public static void Main(string[] args) 
    {
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(25);

        Console.WriteLine("Radius of circle1 is: " + circle1.radius);
        Console.WriteLine("Radius of circle2 is: " + circle2.radius);
    }
}