using System;

class University
{
	int fee = 125000;
	// method to find the discounted amount and payable account for student
	public void DiscountedFee()
	{
		int discountedAmount = fee * 10 / 100;
		int payableAmount = fee - discountedAmount;
		Console.WriteLine(string.Format("The discount amount is INR {0} and final discounted fee is INR {1}", discountedAmount, payableAmount));
	}
}

class Program
{
	static void Main()
	{
		University run = new University();
		run.DiscountedFee();
	}
}