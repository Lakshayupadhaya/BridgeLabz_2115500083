//DateTimeOffset now = DateTimeOffset.UtcNow;
//DateTimeOffset estTime = TimeZoneInfo.ConvertTime(now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

//Console.WriteLine($"UTC Time: {now}");
//Console.WriteLine($"Eastern Time: {estTime}");



using System;

class TimeZoneAndDateTimeOffSet
{
	static void Main(string[] args)
	
	{
		
		//Console.WriteLine(DateTimeOffset.Now);
		//Console.WriteLine(DateTimeOffset.UtcNow);
		
		DateTimeOffset localTime = DateTimeOffset.UtcNow;
		//DateTimeOffset localTime2 = DateTimeOffset.Now;
		
		
		//Console.WriteLine(TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
		
		Console.WriteLine("GMT " + TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")));
		
		Console.WriteLine("IST " + TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time")));
		
		Console.WriteLine("PST " + TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")));
		
		//Console.WriteLine("PST " + TimeZoneInfo.ConvertTime(localTime2, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")));
		
		
		// wether it is utcnow or now it shows the same result while converting because it contains offset from datetimeoffset
	}
}