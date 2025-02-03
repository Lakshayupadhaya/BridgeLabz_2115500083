// bank customerid customername balance bankname bankid ifsccode withdrawl deposit checkBalance

using System;

class Bank
{
	private static string bankName = "State Bank Of India";
	private double bankNo = 0208462;
	private string string ifsc = "SBI2094dac7467";

}

class Customer : Bank
{
	protected string customername;
	protected double customerid;
	private double balance = 0;
	
	public Customer(string name; double id; double balance)
	{
		this.customername = name;
		this. customerid = id;
		this.balance = balance;
		Console.WriteLine("State Bank Of India");
		Console.WriteLine("Welcome" + name);
		
	}
	
	public double GetBalance()
	{
		return this.balance;
	}
	
	protected void SetBalance(double balance)
	{
		this.balance = balance;
	}
	
	protected void Withdrawl()
	{
		Console.WriteLine("enter the amount to be withdrawl");
		double amount = Double.Parse(Console.ReadLine());
		if(this.balance - amount > 2000)
		{
			this.balance = this.balance - amount;
			Console.WriteLine("Withdrawl successfull");
		}
		else
		{
			Console.WriteLine("Balance low");
		}	
	}
	protected void Deposit()
	{
		Console.WriteLine("enter the amount to be deposited");
		double amount = Double.Parse(Console.ReadLine());
		this.balance += amount;
		Console.WriteLine("Deposit successfull");	
	}
	
	Public double CheckBalance()
	{
		return this.balance;
	}
	static void Main()
	{
		Customer c1 = new Customer("Lakshay", 20938263, 923004);
		c1.Withdrawl();
		c1.Deposit();
		c1.checkBalance();
		
	}
}