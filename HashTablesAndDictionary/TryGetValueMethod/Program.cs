using System;
using System.Collections.Generic;
using System.Security;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5},
            { "Banana",2}
        };

        //using TryGetValue
        if(fruitBasket.TryGetValue("Apple", out int appleQuantity))
            Console.WriteLine($"Apple quantity: {appleQuantity}");
        else
            Console.WriteLine($"Apple not found in the basket.");

        //the following line will make exception error becouse orange is not there
        //Console.WriteLine($"Orage quantity: {fruitBasket["Orange"]}");

        //using TryGetValue
        if (fruitBasket.TryGetValue("Orange", out int OrangeQuantity))
            Console.WriteLine($"Orange quantity: {OrangeQuantity}");
        else
            Console.WriteLine($"Orange not found in the basket.");




        Console.ReadKey();
    }
}

