using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    static void Main(string[] args)
    {

        //list initialization
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //adding an element
        numbers.Add(11);
        Console.WriteLine("\nAfter Addng 11: " + string.Join(", ", numbers));
        
        //inserting an element at a specific position
        numbers.Insert(0, 0);
        Console.WriteLine("\nAfter inserting 0 at the begginning: "+ string.Join(", ",numbers));


        //inserting multiple elements
        numbers.InsertRange(5, new List<int> { 55, 56 });
        Console.WriteLine("\nAfter inserting mutiple elements in a specific position: " + string.Join(", ", numbers));





        Console.ReadKey();
    }
}

