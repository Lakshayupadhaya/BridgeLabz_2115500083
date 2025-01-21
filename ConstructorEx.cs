using System;

public class ConstructorEx
{
	int val;
	string lang;
	
	public ConstructorEx(int val, string lang){
		
		this.val = val;
		this.lang = lang;
	}
		
	
	static void Main()
	{
		ConstructorEx cnst = new ConstructorEx(10, "csharp");
		Console.WriteLine(cnst.val);
		Console.WriteLine(cnst.lang);
		
		
		
	}

}
