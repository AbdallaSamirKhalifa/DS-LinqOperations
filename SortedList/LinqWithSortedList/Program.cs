using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> sortedList = new SortedList<int, string>
        {
            {1, "One" },
            {3, "Three" },
            {2, "Two" },
            {4, "Four" }
        };

        //Query using query expression syntax
        var queryExpressionSyntax = from kvp in sortedList
                                    where kvp.Key > 1 // Filter keys greater than 1
                                    select kvp;

        Console.WriteLine("Query Expression syntax results:");
        foreach (var item in queryExpressionSyntax)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }

        //Query using query method
        var methodSyntax = sortedList.Where(kvp => kvp.Key > 1);
        Console.WriteLine("\nMethod syntax results:");
        foreach (var item in methodSyntax)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }

        //filter jey-value pairs with keys greater than a specific vlue
        int specificValue = 2;
        var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue);

        Console.WriteLine($"\nEntries with keys greater than {specificValue}:");
        foreach (var item in filteredByKey)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }


        Console.ReadKey();
    }
}

