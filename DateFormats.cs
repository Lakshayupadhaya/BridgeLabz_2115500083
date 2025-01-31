//EEE → Abbreviated day of the week (e.g., "Mon", "Tue", "Wed").
//MMM → Abbreviated month name (e.g., "Jan", "Feb", "Mar").
//dd → Two-digit day of the month (e.g., "01", "15", "31").
//yyyy → Four-digit year (e.g., "2024").


//"EEEE, MMM dd, yyyy" → Full weekday name (e.g., "Friday, Jan 31, 2025").
//"EEE, MMM dd, yy" → Two-digit year (e.g., "Fri, Jan 31, 25").
//"dd/MM/yyyy" → Numeric date format (e.g., "31/01/2025").
//"yyyy-MM-dd" → ISO standard format (e.g., "2025-01-31").



using System;

class DateFormats
{
	static void Main(string[] args)
	{
		DateTime date = DateTime.Now;
		
		Console.WriteLine(date);
		
		Console.WriteLine(date.ToString("dd/MM/yyyy"));
		
		
		Console.WriteLine(date.ToString("yyyy-MM-dd"));
		
		//eee is not in c# it is a abrevation in java for the day of the week it is ddd
		//Console.WriteLine(date.ToString("EEE, MMM dd, yyyy"));
		
		Console.WriteLine(date.ToString("ddd, MMM dd, yyyy"));
	}

}