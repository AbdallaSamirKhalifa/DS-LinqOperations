using System;
using System.Collections.Generic;



internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> fruits = new HashSet<string>();

        //Adding elements to the Hashset
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        //trying to add a duplicate element
        //the following 3 record will be ignored due to its duplication
        fruits.Add("Apple");
        fruits.Add("Apple");
        fruits.Add("Apple");


        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        Console.ReadKey();
    }
}

