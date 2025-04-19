using System;
using System.Collections.Generic;
using System.Linq;



internal class Program
{
    static void Main(string[] args)
    {
        //SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        ////filtering elements greater than 2

        //var filteredSet = set.Where(e => e > 2);
        //Console.WriteLine("Filtered Set:");
        //foreach (var item in filteredSet)
        //{
        //    Console.Write(item + " ");
        //}

        ////sum of all elements
        //var sum = set.Sum();
        //Console.WriteLine($"\nSum of all elements: {sum}");


        //// max and min elements
        //Console.WriteLine($"\nMax element: {set.Max}");
        //Console.WriteLine($"Min element: {set.Min}");


        ////sorting set in descending order
        //var descendingOrder = set.OrderByDescending(e => e);
        //Console.WriteLine("\nDescending sorted set:");
        //foreach (var item in descendingOrder)
        //{
        //    Console.Write(item + " ");
        //}
        //-----------------------------Emaple2------------------------------------------------------
        SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //find event number and project them to their square
        var evenNumbersSquared = set.Where(n => n % 2 == 0).Select(n => n * n);
        Console.WriteLine("Squares of even numbers:");
        foreach (var item in evenNumbersSquared)
        {
            Console.Write(item + " ");
        }



        Console.ReadKey();

    }
}

