using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        Console.WriteLine($"HashSet Item Count: {fruits.Count}");

        //Removing banana from the hashset
        fruits.Remove("Banana");

        Console.WriteLine($"\nHashSet Item Count after removing Banana: {fruits.Count}");

        foreach (string fruit in fruits)
            Console.WriteLine(fruit);       
                


        //this will remove all elements
        fruits.Clear();

        Console.WriteLine($"\nHashSet Item Count after clear: {fruits.Count}");
        
        Console.ReadKey();
    }
}

