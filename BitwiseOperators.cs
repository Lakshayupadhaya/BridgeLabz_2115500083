using System;

class BitwiseOperators
{
	static void Main()
	{
		int a = 3;
		int b = 5;
		
		Console.WriteLine("3 and 5 is: " + (a & b)); // 0011 & 0101 is 0001 it gives 1 if both are 1
		Console.WriteLine("3 or 5 is: " + (a | b)); // 0011 | 0101 is 0111 it gives 1 if either one is 1
		Console.WriteLine("3 xor 5 is: " + (a ^ b)); // 0011 & 0101 is 0110 it gives 1 if both are are different
		Console.WriteLine("compliment of 3 is: " + (~a)); // inverts all bits
		Console.WriteLine("rightshift 3: " + (a>>1)); // 0011 >>1 is 0001 shifts bit to the right
		Console.WriteLine("leftshift 3: " + (a<<1)); // 0011 <<1 is 0110 shifts bit to the left
		
	}
}