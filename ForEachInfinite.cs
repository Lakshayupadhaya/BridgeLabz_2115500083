using System;
using System.Collections.Generic;

class ForEachInfinite
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1 };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            numbers.Add(num + 1); // Keeps adding new elements
        }
    }
}
