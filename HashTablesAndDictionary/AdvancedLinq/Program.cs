using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        //Dictionary for grouping'
        Dictionary<string, string> fruitCatergory = new Dictionary<string, string>
        {
            {"Apple","Tree" },
            {"Banana","Herb" },
            {"Cherry","Tree" },
            {"Strawberry","Bush" },
            {"Raspberry","Bush" }
        };

        //groubing fruits category
        var groupedFruits = fruitCatergory.GroupBy(kpv => kpv.Value);
        foreach(var group in groupedFruits)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach(var fruit in group)
             Console.WriteLine($" -{fruit.Key}");
                
        }

        //another dictionary for combined queries
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            {"Apple",5 },
            {"Banana",2 },
            {"Orange",7 }

        };
        //combined linq queries

        var sortedFilteredFruits = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value })
            .Where(kpv => kpv.Value > 3).OrderBy(kpv => kpv.Key);
        Console.WriteLine($"\nSorted and filterd fruits:");
        foreach (var item in sortedFilteredFruits)
        {
            Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
        }






        Console.ReadKey();
    }
}

