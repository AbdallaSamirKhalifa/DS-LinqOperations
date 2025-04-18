using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Removing item by value
        numbers.Remove(5);
        Console.WriteLine($"\nAfter removing 5: {string.Join(", ", numbers)}");

        //Removing item by index
        numbers.RemoveAt(0);
        Console.WriteLine($"\nAfter removing the first element: {string.Join(", ", numbers)}");


        //removing multible items
        numbers.RemoveRange(0,2);
        Console.WriteLine($"\nAfter removing the first 2 elements(1,2): {string.Join(", ", numbers)}");


        numbers.RemoveAll(n => n % 2 == 0);
        Console.WriteLine($"\nAfter removing all even numbers: {string.Join(", ", numbers)}");


        //clearing list
        numbers.Clear();
        Console.WriteLine($"After clearing the list: {numbers.Count}, Capacity: {numbers.Capacity}");
        

        Console.ReadKey();
    }
}

