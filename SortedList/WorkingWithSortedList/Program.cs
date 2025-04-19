using System;
using System.Collections.Generic;
using System.Configuration;



internal class Program
{
    static void Main(string[] args)
    {
        SortedList<string, int> sortedList = new SortedList<string, int>();

        sortedList.Add("banana", 2);
        sortedList.Add("Orange", 3);
        sortedList.Add("apple", 3);

        Console.WriteLine($"\nQuantity of apples: {sortedList["apple"]}");


        Console.WriteLine($"\nIterating sorted list elements:");
        foreach (var item in sortedList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }


        sortedList.Remove("apple");

        Console.WriteLine($"\nIterating sorted list elements after removing apple:");
        foreach (var item in sortedList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        Console.ReadKey();
    }
}

