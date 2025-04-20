using System;
using System.Collections;
using System.Collections.Generic;




internal class Program
{
    static void Main(string[] args)
    {
        //    ArrayList list = new ArrayList();

        //    list.Add(10);
        //    list.Add(20);
        //    list.Add(30);

        //    Console.WriteLine("Elements of array list:");
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    list.Remove(20);
        //    list.TrimToSize();

        //    Console.WriteLine("\nElements of array list after removal:");
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        //example of adding elements of different data types
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(true);
        list.Add("Hello");

        Console.WriteLine($"Total element in array list: {list.Count}");

        Console.WriteLine("\nContent of the array list using index:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Index {i}: {list[i]}");
        }

        list.Remove("Hello");//removes the first occurrence of a specified element
        Console.WriteLine("\nContent of the array list after removal:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Index {i}: {list[i]}");
        }


        Console.ReadKey();
    }
}

