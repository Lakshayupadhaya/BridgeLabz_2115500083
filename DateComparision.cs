using System;

class DateComparision
{
	static void Main(string[] args)
	{
		// taking input from the user in date
		Console.WriteLine("Enter date1 in yyyy-mm-dd or mm-dd-yyyy");
		DateTime date1 = DateTime.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter date2 in yyyy-mm-dd or mm-dd-yyyy");
		DateTime date2 = DateTime.Parse(Console.ReadLine());

		int check = DateTime.Compare(date1, date2);//comparing two dates
		
		//checks if date 1 < than date 2
		if(check < 0)
		{
			Console.WriteLine("Date {0} is before {1}", date1.ToString("dd-MM-yyyy"), date2.ToString("dd-MM-yyyy"));// mm as a abrevation for date prints it to 00 instead of month
		}
		// checks if date 1 > date 2
		else if(check > 0)
		{
			Console.WriteLine("Date {0} is after {1}", date1.ToString("dd-MM-yyyy"), date2.ToString("dd-MM-yyyy"));
		}
		// if the ans is zero than both the dates are same
		else
		{
			Console.WriteLine("Date {0} and {1} are same", date1.ToString("dd-MM-yyyy"), date2.ToString("dd-MM-yyyy"));
		}
	}
}