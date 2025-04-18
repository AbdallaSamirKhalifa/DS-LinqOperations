using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        //List<int> nums = new List<int> { 44, 22, -55, 666, 9, -6, 345, 11, 3, 3 };

        ////using contains
        //Console.WriteLine($"Is list contains 9: {nums.Contains(9)}");

        ////using exists
        //Console.WriteLine($"Is list contains negative numbers: {nums.Exists(n => n < 0)}");

        ////using find
        //Console.WriteLine($"First negative number: {nums.Find(n => n < 0)}");

        ////using FindAll
        //Console.WriteLine($"All negative numbers: {string.Join(", ", nums.FindAll(n => n < 0))}");

        ////using Any
        //Console.WriteLine($"Is there any numbers grater than 100: {nums.Exists(n => n > 100)}");

        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry",
            "fig", "grape", "honeydew" };

        Console.WriteLine($"List contains 'apple': {words.Contains("apple")}");

        Console.WriteLine($"List contains a word of length 5: {words.Exists(word => word.Length == 5 )}");

        Console.WriteLine($"first word longer than 5: {words.Find(word => word.Length > 5 )}");


        Console.WriteLine($"words longer than 5 characters: {string.Join(", ", words.FindAll(word => word.Length > 5))}");

        Console.WriteLine($"All words stars with a: {string.Join(", ", words.FindAll(word => word.StartsWith("a")))}");

        Console.WriteLine($"All words ends with a: {string.Join(", ", words.FindAll(word => word.EndsWith("a")))}");
        
        Console.WriteLine($"Any word starts with a: { words.Any(word => word.StartsWith("a"))}");

        Console.WriteLine($"Any word ends with a: { words.Any(word => word.EndsWith("a"))}");




        Console.ReadKey();
    }
}

