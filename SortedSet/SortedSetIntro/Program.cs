using System;
using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> set = new SortedSet<int>();

        set.Add(5);
        set.Add(2);
        set.Add(8);
        set.Add(3);


        //the elements will be printed sorted in ascending order.
        Console.WriteLine("Sorted set elements:");
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }



        //check if element exists in the sorted set
        int target = 3;
        if (set.Contains(target))
            Console.WriteLine($"\nNumber {target} exists in the sorted set.");
        else
            Console.WriteLine($"\nNumber {target} does not exists in the sorted set.");


        //remove an element from the sorted set
        set.Remove(target);//if the number does not exist it will not cause an

        Console.WriteLine("\nSorted set elements after removal:");
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}

