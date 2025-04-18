using System;
using System.Collections.Generic;
using System.Linq;




internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /*
        //Aggregate operations
        Console.WriteLine($"Sum: {nums.Sum()}");
        Console.WriteLine($"Average: {nums.Average()}");
        Console.WriteLine($"Minimum: {nums.Min()}");
        Console.WriteLine($"Maxmum: {nums.Max()}");
        Console.WriteLine($"Count: {nums.Count()}");

        */

        //LINQ Filtering

        Console.WriteLine($"Even Numbers: {string.Join(", ",nums.Where(n => n % 2 == 0))}");
        Console.WriteLine($"ODD Numbers: {string.Join(", ",nums.Where(n => n % 2 != 0))}");
        Console.WriteLine($"Numbers grater than 5 : {string.Join(", ",nums.Where(n => n > 5))}");
        Console.WriteLine($"Every seconed number : {string.Join(", ",nums.Where((n, index)=> index % 2 == 1))}");
        Console.WriteLine($"Numbers between 3 and 0 : {string.Join(", ",nums.Where(n => n > 3 && n < 8))}");


        Console.ReadKey();
    }
}

