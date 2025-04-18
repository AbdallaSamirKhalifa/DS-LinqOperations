using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5},
            { "Banana",2},
            { "Orange",7}
        };
        
        //using linq to transform items
        var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });

        Console.WriteLine("\nTransformed Items:");
        foreach(var item in fruitInfo)
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");

        //using linq to filter items
        var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);
        Console.WriteLine("\nFiltered Items > 3:");
        foreach (var item in filteredFruit)
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");

        //using linq to sort by value
        var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value );
        
        Console.WriteLine("\nItems sorted by Quantity:");
        foreach (var item in sortedByQuantity)
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");

        //uisng linq to sort items desc
        var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);

        Console.WriteLine("\nItems sorted by Quantity Descending:");
        foreach (var item in sortedByQuantityDesc)
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");

        //using linq to aggregate data
        Console.WriteLine("\nAggregations:");
        int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);
        Console.WriteLine($"Total Quantity: {totalQuantity}");

        double AvgQuantity = fruitBasket.Average(kpv => kpv.Value);
        Console.WriteLine($"Average Quantity: {AvgQuantity}");


        int MinQuantity = fruitBasket.Min(kpv => kpv.Value);
        Console.WriteLine($"Min Quantity: {MinQuantity}");

        int MaxQuantity = fruitBasket.Max(kpv => kpv.Value);
        Console.WriteLine($"Max Quantity: {MaxQuantity}");

        Console.ReadKey();
    }
}

