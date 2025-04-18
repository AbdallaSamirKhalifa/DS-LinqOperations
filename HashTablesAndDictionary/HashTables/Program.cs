using System;
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        Hashtable myHashTable = new Hashtable();
        myHashTable.Add("Key1", "Value1");
        myHashTable.Add("Key2", "Value2");
        myHashTable.Add("Key3", 100);


        //Accessing an element
        Console.WriteLine($"Accessing Key1: {myHashTable["Key1"]}");

        //modifying an element
        myHashTable["Key1"] = "New value1";

        //Removing an element
        myHashTable.Remove("Key2");

        //iterating over elements
        Console.WriteLine("\ncurrent Hashtable contents");
        foreach (DictionaryEntry entry in myHashTable) 
            Console.WriteLine($"key: {entry.Key},  Value: {entry.Value}");
        
        Console.ReadKey();
    }
}

