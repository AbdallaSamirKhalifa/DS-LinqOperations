using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> fruits = new HashSet<string>
        {
            "Apple", "Banana", "Cherry"
        };

        //checking if Apple is in the hashset
        if (fruits.Contains("Apple"))
            Console.WriteLine("Apple is in the HashSet");
        else
            Console.WriteLine("Apple is not in the HashSet");

        //checking if Orange is in the hashset
        if (fruits.Contains("Ornage"))
            Console.WriteLine("Orange is in the HashSet");
        else
            Console.WriteLine("Orange is not in the HashSet");




        Console.ReadKey();
    }
}

