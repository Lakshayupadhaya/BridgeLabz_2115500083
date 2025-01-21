using System;

class StaticAndNonStatic 
{
	static int staticVariable = 10;
	int nonStaticVariable = 100;
	public void NonStaticMethod()
	{
		Console.WriteLine("i am non static method");
	}
	
	public static void StaticMethod()
	{
		
		Console.WriteLine("i am static method");
	}
	public static void StaticCallingNonStatic()
	{
		Console.WriteLine("Static calling non static");
		StaticAndNonStatic fan = new StaticAndNonStatic();// to call a non static method in static  An object reference is required for the non-static field, method, or property  
		fan.NonStaticMethod();
	}
	public void NonStaticCallingStatic()
	{
		Console.WriteLine("non Static calling static");
		StaticMethod();
	}
	
	static void Main()
	{
		StaticAndNonStatic demo = new StaticAndNonStatic();
		StaticAndNonStatic.StaticCallingNonStatic();
		demo.NonStaticCallingStatic();
	}
	
}

