using System;
using System.Collections.Generic;
using System.Linq;




internal class Program
{
    static void Main(string[] args)
    {
        // Initialize a SortedList of int keys and string values with fruit names
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };

        //Groupiing by the length of the value
        Console.WriteLine("Grouping by the length of the value:");
        var groups = sortedList.GroupBy(kpv => kpv.Value.Length);
        foreach (var group in groups.Where(kpv => kpv.Key > 3))
            Console.WriteLine($"Length {group.Key}: {string.Join(", ", group.Select(kpv => kpv.Value))}");
         

        Console.ReadKey();
    }
}

