using System;

class Spring
{
	// method to check if season is string
	public static bool SpringSeason()
	{
		// input from the user
		Console.WriteLine("Enter the month in numerical value: ");
		int month = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the day in numerical value: ");
		int day = Convert.ToInt32(Console.ReadLine());
		
		//string currentDayDate = "" + month + "/" + day + "";
		
		//if(currentDayDate >= "3/20" && currentDayDate <= "6/20")
		if (month ==3 && day >= 20 || month >= 4 && month <= 5 || month ==6 && day <=20)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	static void Main(string[] args)
	{
		Console.Write(SpringSeason()? "Its a Spring Season" : "Not a Spring Season");
	}
}