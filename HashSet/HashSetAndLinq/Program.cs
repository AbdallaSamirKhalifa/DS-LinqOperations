using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        // Creating and populating a HashSet of integers
        //HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        ////Using linq to filter out even numbers
        //var evenNums = numbers.Where(n => n % 2 == 0);

        //Console.WriteLine("Even Numbers: ");
        //foreach (var number in evenNums)
        //{
        //    Console.WriteLine(number);
        //}


        ////Using linq to find numbers greater than 5
        //var numbersGreaterThanFive = numbers.Where(n => n > 5);

        //Console.WriteLine("\nNumber greater than five: ");
        //foreach (var number in numbersGreaterThanFive)
        //{
        //    Console.WriteLine(number);
        //}


        // Creating and populating a HashSet of strings
        HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

        //using Linq to filter names that starts with C
        var namesStartsWithC = names.Where(n => n.StartsWith("C"));

        Console.WriteLine("Names starts with C:");
        foreach (var name in namesStartsWithC)
        {
            Console.WriteLine(name);
        }

        // Using Linq to find the names with length grater than 4 characters
        var namesLongerThanFour = names.Where(n => n.Length > 4);

        Console.WriteLine("\nNames Longer than four characters:");
        foreach (var name in namesLongerThanFour)
        {
            Console.WriteLine(name);
        }


        Console.ReadKey();
    }
}

