using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


        //Default sorting (Ascending)
        nums.Sort();
        Console.WriteLine($"Sorted in ascending order: {string.Join(", ", nums)}");

        //Sorting in descending order
        nums.Reverse();
        Console.WriteLine($"Sorted in descending order: {string.Join(", ", nums)}");


        //Sorting with LINQ
        Console.WriteLine($"Sorted ascending with linq: {string.Join(", ", nums.OrderBy(n => n))}");
        Console.WriteLine($"Sorted descending with linq: {string.Join(", ", nums.OrderByDescending(n => n))}");


        nums.Sort((a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));
        Console.WriteLine("Sorted by Absolute Values: " + string.Join(", ", nums));

        Console.ReadKey();
    }
}

