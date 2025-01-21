using System;

public class StaticConstructorEx
{
	public int val;
	public string lang;
	public static string fact;
	
	public StaticConstructorEx(int val, string lang){
		
		this.val = val;
		this.lang = lang;
	}
	
	static StaticConstructorEx()
	{
		fact = "Not Easy and fun";
	}
	
	//public void display()
	//{
	//	Console.WriteLine(val+" "+lang+" "+fact);
		
	//}
	

		
	
	static void Main()
	{
		StaticConstructorEx cnst = new StaticConstructorEx(10, "csharp");
		//cnst.display();
		Console.WriteLine(cnst.val);
		Console.WriteLine(cnst.lang);
		Console.WriteLine(fact);
		//Console.WriteLine(StaticConstructorEx.fact works the same as above line
		
		StaticConstructorEx cnst1 = new StaticConstructorEx(8, "java");
		//cnst1.display();
		Console.WriteLine(cnst1.val);
		Console.WriteLine(cnst1.lang);
		Console.WriteLine(fact);
		
		//Console.WriteLine(cnst1.fact); this line was giving error --> Member 'StaticConstructorEx.fact' cannot be accessed with an instance
		
		
		
		
	}

}