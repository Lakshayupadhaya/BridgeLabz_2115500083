using System;

class FindSign
{
	// method to check if the number is -ve or +ve or zero
	public static int CheckPosNegZero()
	{
		// taking input from the user
		Console.WriteLine("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		if(number > 0)
		{
			return 1;
		}
		
		else if(number < 0)
		{
			return -1;
		}
		
		else
		{
			return 0;
		}
	}
	
	static void Main(string[] args)
	{
		Console.Write(CheckPosNegZero());
	}
}