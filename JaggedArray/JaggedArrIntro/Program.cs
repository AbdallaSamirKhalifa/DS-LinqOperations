using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;




internal class Program
{
    static void Main(string[] args)
    {
        //int[][] JaggedArray = new int[3][];

        //JaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        //JaggedArray[1] = new int[] { 0, 2, 4 };
        //JaggedArray[2] = new int[] { 11, 22 };

        //for (int i = 0; i < JaggedArray.Length; i++)
        //{
        //    for ( int j = 0; j < JaggedArray[i].Length; j++)
        //    {
        //        Console.Write(JaggedArray[i][j] + " ");
        //    }
        //    Console.WriteLine();
        //}




        //-----------------------------------LINQ with jagged array-----------------------------------
        int[][] jaggedArray = {
            new int[] { 1,2,4},
            new int []{ 4,5,6},
            new int[]{ 7,8,9,10}
        };

        //flatten the jagged array and sum all elements

        int totalSum = jaggedArray.SelectMany(subArray => subArray).Sum();
        Console.WriteLine($"Total Sum: {totalSum}");

        //find maximum element in the jagged array
        int max = jaggedArray.SelectMany(subArray => subArray).Max();
        Console.WriteLine($"\nMaximum Element: {max}");

        //filter array having more than 3 elements and select their first element
        int first = jaggedArray.Where(subArray => subArray.Length > 3).SelectMany(subArray => subArray).First();
        Console.WriteLine($"\nFirst Element: {first}");
        //other way of selecting the first element 
        var firstElement = jaggedArray.Where(a => a.Length > 3).Select(subArray => subArray.First());

        foreach (var element in firstElement)
            Console.WriteLine($"Other way for the first element: {element}");






        Console.ReadKey();
    }
}

