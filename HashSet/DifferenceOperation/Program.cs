using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


        //Removing elements of set 2 from set1'
        //this remove the common elements between set1 and set2 ffrom set1
        //set1.ExceptWith(set2);


        //Console.WriteLine("Differnece of sets (set1 - set2):");
        //foreach (int item in set1)
        //{
        //    Console.WriteLine(item);

        //}

        ////adding the element becouse its already removed from the set
        //set1.Add(3);

        ////Removing elements of set 1 from set2'
        ////this remove the common elements between set2 and set1 from set2
        //set2.ExceptWith(set1);

        //Console.WriteLine("\nDiffernece of sets (set2 - set1):");
        //foreach (int item in set2)
        //{
        //    Console.WriteLine(item);

        //}


        //------------------------------------SymmetricDifference---------------------------------

        //Retaining elements unique to each set

        set1.SymmetricExceptWith(set2);

        Console.WriteLine("\nSymmetric Differnece of sets:");
        foreach (int item in set2)
        {
            Console.WriteLine(item);

        }
        Console.ReadKey();
    }
}

