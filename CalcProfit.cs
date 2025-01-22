using System;

class CalcProfit
{
	float costPrice = 129f;
	float sellingPrice = 191f;
	// method to print profit and percentage and print multiple lines using single print statement
	public void ShowDetails()
	{
		float profit = sellingPrice - costPrice;//62
		//Console.WriteLine(profit);//62
		float profitPrecentage = (profit / costPrice) * 100f;//62/129*100
		//float profitPrecentage = (Convert.ToSingle(profit) / Convert.ToSingle(costPrice)) * Convert.ToSingle(100);
		//Console.WriteLine(Convert.ToSingle((profit / costPrice) * 100));
		//float a=191f-129f;
		//a/=129f;
		//a*=100f;
	
		//Console.WriteLine(a);
		
		Console.WriteLine(string.Format("The Cost Price is INR {0} and Selling Price is INR {1}\nThe Profit is INR {2} and the Profit Percentage is {3}", costPrice, sellingPrice, profit, profitPrecentage));
	
	}
}

class Program
{
	static void Main()
	{
		CalcProfit run = new CalcProfit();
		run.ShowDetails();
	}
}