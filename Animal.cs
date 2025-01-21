using System;

public class Animal
{
	string color;
	string habitat;
	
	// public Animal(string color, string habitat){}

	
	public void display()
	{
		// Console.WriteLine(string.Format("Animal color is {0} and his/her habitat is {1}", this.color, this.habitat));
		
		this.color = "Elephant";
		this.habitat = "Water";
		Console.WriteLine(string.Format("Animal color is {0} and his/her habitat is {1}", color, habitat));
	}
	static void Main()
	{
		Animal dog = new Animal();
		dog.color = "White";
		Console.WriteLine(dog.color);
		dog.habitat = "Land";
		Console.WriteLine(dog.habitat);
		
		dog.display();
		
	}

}
