using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;



internal class Program
{
    static void Main(string[] args)
    {



        //---------------------------------------------------Fitering-----------------------------------
        //ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //// we uses the cast here to convert it to int befor applying the search
        //var evenNumbers = list.Cast<int>().Where(n => n % 2 == 0);


        //Console.WriteLine("All even numbers:");
        //foreach (var item in evenNumbers)
        //{
        //    Console.WriteLine(item);
        //}


        //---------------------------------------------------Aggregate Fuctions-----------------------------------

        //ArrayList list = new ArrayList { 10, 5, 20, 15, 30 };


        //var minVal = list.Cast<int>().Min();
        //var maxVal = list.Cast<int>().Max();
        //var sum = list.Cast<int>().Sum();
        //var average = list.Cast<int>().Average();
        //var count = list.Cast<int>().Count();//linq method


        //Console.WriteLine("Array list items");
        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.Write(list[i].ToString() + " ");
        //}

        //Console.WriteLine("\n\nMinimum value in the ArrayList: " + minVal);
        //Console.WriteLine("Maximum value in the ArrayList: " + maxVal);
        //Console.WriteLine("Sum values in the ArrayList: " + sum);
        //Console.WriteLine("Average values in the ArrayList: " + average);
        //Console.WriteLine("Count Items in the ArrayList: " + count);

        //list.Sort();

        //Console.WriteLine("\nArray list items after sorting:");
        //for (int i = 0; i < list.Count; i++)
        //{
        //    Console.Write(list[i].ToString() + " ");
        //}

        //Coutnting occurences of a specific element

        ArrayList arrayList = new ArrayList { 1, 2, 3, 2, 4, 2, 5 };

        int targetNumber = 2;
        var count = arrayList.Cast<int>().Count(n => n == targetNumber);

        Console.WriteLine($"Number of occurrences of {targetNumber} in the ArrayList: {count}");




        Console.ReadKey();
    }
}

