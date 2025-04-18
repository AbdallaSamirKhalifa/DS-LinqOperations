using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        //---------------------------------SetEquals--------------------------------------------
        //HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        //HashSet<int> set2 = new HashSet<int> { 1, 2, 3 };
        //HashSet<int> set3 = new HashSet<int> { 3, 4, 5 };

        //Console.WriteLine($"set1 equals set2 {set1.SetEquals(set2)}");
        //Console.WriteLine($"set1 equals set3 {set1.SetEquals(set3)}");

        //---------------------------------IsSubSetOf--------------------------------------------
        //HashSet<int> set1 = new HashSet<int> { 1, 2 };
        //HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };

        //Console.WriteLine($"set1 is a subset of set2: {set1.IsSubsetOf(set2)}");
        //Console.WriteLine($"set2 is a subset of set1: {set2.IsSubsetOf(set1)}");

        //---------------------------------IsSuperSetOf--------------------------------------------
        //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        //HashSet<int> set2 = new HashSet<int> { 2, 3 };

        //Console.WriteLine($"set1 is a super set of set2: {set1.IsSupersetOf(set2)}");

        //---------------------------------Overlaps--------------------------------------------
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> set3 = new HashSet<int> { 6, 7, 8 };


        Console.WriteLine($"set1 overlaps set2: {set1.Overlaps(set2)}");
        Console.WriteLine($"set1 overlaps set3: {set2.Overlaps(set3)}");

        Console.ReadKey();
    }
}

