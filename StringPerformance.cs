namespace ConsoleApp1;

using System;
using System.Diagnostics;
using System.Text;

class StringPerformance
{
    static void Main()
    {
        int n = 100000;

		//Appending in a string every time creates a new strinng
        Stopwatch sw = new Stopwatch();
        sw.Start();
        string str = "";
        for (int i = 0; i < n; i++)
        {
            str += "a"; 
        }
        sw.Stop();
        Console.WriteLine($"String Concatenation Time: {sw.ElapsedMilliseconds}");
		
        sw.Restart();
		// Appending in a string builder
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        sw.Stop();
        Console.WriteLine($"StringBuilder Concatenation Time: {sw.ElapsedMilliseconds}");

    }
}