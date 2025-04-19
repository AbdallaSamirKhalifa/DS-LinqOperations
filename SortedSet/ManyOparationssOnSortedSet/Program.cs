using System;
using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3, 4, 5, };
        SortedSet<int> set2 = new SortedSet<int> { 3, 4, 5, 6, 7 };

        //Union
        SortedSet<int> unionSet = new SortedSet<int>(set1);
        unionSet.UnionWith(set2);
        Console.WriteLine("\nUnion");
        foreach (var item in unionSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        //intersection
        //this one gets the common values between the two sets
        SortedSet<int> intersectionSet = new SortedSet<int>(set1);
        intersectionSet.IntersectWith(set2);

        Console.WriteLine("\nIntersection:");
        foreach (var item in intersectionSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        //Difference
        // this one gets the values thats in the corresponding set and not in the other
        SortedSet<int> differenceSet = new SortedSet<int>(set1);
        differenceSet.ExceptWith(set2);
        //differenceSet.SymmetricExceptWith(set2); //this one unions the two sets and removes the common values form
        //the conrressponding set
        Console.WriteLine("\nDifference (set1 - set2):");
        foreach (var item in differenceSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        

        // subset and superset
        Console.WriteLine($"\nSet1 subset of set2: {set1.IsSubsetOf(set2)}");
        Console.WriteLine($"\nSet1 superset of set2: {set1.IsSupersetOf(set2)}");


        Console.ReadKey();
    }
}

