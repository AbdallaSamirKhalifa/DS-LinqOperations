using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

        // Adding elements to the SortedDictionary
        sortedDict.Add("apple", 10);
        sortedDict.Add("banana", 20);
        sortedDict.Add("orange", 15);

        //Displaying the content of the sorted dictionary
        Console.WriteLine("Content of the sorted dictionary:");
        foreach (var item in sortedDict)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        //accessing values by key
        Console.WriteLine($"\nAccessing values by key:");
        Console.WriteLine($"Values of apple: {sortedDict["apple"]}");
        Console.WriteLine($"Values of banana: {sortedDict["banana"]}");
        Console.WriteLine($"Values of orange: {sortedDict["orange"]}");

        //this line will throw an error, You can't access element that is not exist in the dictionary
        //Console.WriteLine($"Values of grape: {sortedDict["grape"]}");


        //checking if key exists
        Console.WriteLine($"\nChecking if key exits:");
        Console.WriteLine($"Contains banana: {sortedDict.ContainsKey("banana")}");
        Console.WriteLine($"Contains grape: {sortedDict.ContainsKey("grape")}");


        //removing element
        //sortedDict.Remove("grape");//this line is okey and it want throw an error
        //(you can use the method for non existed item)
        sortedDict.Remove("banana");
        Console.WriteLine("\nContents of the sorted dictionary after removal:");
        foreach (var item in sortedDict)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

        }


        Console.ReadKey();
    }
}

