using System;

class GuessingGame
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the number between 1 and 100");
		int number = Convert.ToInt32(Console.ReadLine());
		
		Random rand = new Random();
		int guess = rand.Next(1, 101);
		//Console.WriteLine(guess);
		int high = 101;// to keep finding the highest closest to that number
		int low = 0;// to keep finding the lowest closest to that number
		
		bool flag = true;
		while(flag)
		{
			Console.Write("guessed number is :" + guess);
			Console.WriteLine("Enter the feedback: ");
			string feedback = Console.ReadLine();
			if(feedback == "high")
			{
				int temp = guess;
				high = guess;
				guess = rand.Next(low, temp);
			}
			else if (feedback == "low")
			{
				int temp = guess;//11
				low = guess;//11
				guess = rand.Next(temp, high);
			}
			else if(feedback == "correct")
			{
				Console.WriteLine("Guessed correctly ending the game xoxo");
				flag = false;
			}
			
		}
	}
}