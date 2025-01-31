using System;

class Prime
{
	//method to check if the number is prime
	public static string CheckPrime(int number)
	{
		// checks for zero and one and returning result accordingly
		if(number < 2){
			string result = number <2 && number!=0 ? ("Number " + number +" is  prime") : ("Number " + number +" is not prime");
			return result;
		}
		// checks if the number is divisible by any upto that number
		for(int i=2; i<number; i++)
		{
			if(number % i == 0)
			{
				return "Number " + number +" is not prime";
			}
		}
		return "Number " + number +" is  prime";// returns number is prime after completing for loop
	}
	
	static void Main(string[] args)
	{
		//taking input from the user
		Console.WriteLine("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		string result = CheckPrime(number);//method calling
		Console.WriteLine(result);
	}
}