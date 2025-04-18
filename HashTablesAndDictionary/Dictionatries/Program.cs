using System;
using System.Collections;
using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> fruitBasket=new Dictionary<string,int>();

        //Adding elements
        fruitBasket.Add("Apple", 5);
        fruitBasket.Add("Banana", 2);
        //the following commented line will cause an error becouse the key is repeated
        //fruitBasket.Add("Banana", 2);
        fruitBasket.Add("Orage", 12);

        //Accessing and updating elements
        fruitBasket["Apple"] = 10;

        Console.WriteLine("\nDictionary content:");
        //iterating through the dictionary
        foreach(KeyValuePair<string,int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }



        //Checking if key exists
        if (fruitBasket.ContainsKey("Banana"))
            //Removing element
            fruitBasket.Remove("Banana");


        Console.WriteLine("\nDictionary content after removing Banana: ");
        //iterating through the dictionary after removing the banana
        foreach (KeyValuePair<string, int> item in fruitBasket)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }


        Console.ReadKey();
    }
}

