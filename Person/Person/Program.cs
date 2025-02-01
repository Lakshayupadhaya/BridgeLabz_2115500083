using System;

class Person 
{
    //attributes of person name and age
    private string name;
    private int age;
    //Cosntructor
    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }

    public Person(Person p1) 
    {
        this.name = p1.name;// this will also work without this.
        this.age = p1.age;
    }

    static void Main() 
    {
        Person p1 = new Person("Lakshay", 21);//creating instance of class people
        Person p2 = new Person(p1);// passing an object in parameter

        Console.WriteLine(p1.name);
        Console.WriteLine(p1.age);
        Console.WriteLine(p2.name);
        Console.WriteLine(p2.age);
    }
}