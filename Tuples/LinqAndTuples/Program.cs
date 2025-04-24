using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<(int ID, string Name, int Age)> people = new List<(int ID, string Name, int Age)>
        {
            (1,"Alice",30),
            (2,"Bob",25),
            (3,"Charlie",35),
            (4,"Diana",28)
        };

        //sorting in descending order
        var DescendingOrder = people.OrderByDescending(p => p.Age);
        foreach (var item in DescendingOrder)
        {
            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.Age}");
        }


        //filter people with age above 30
        var filteredPeople = people.Where(x => x.Age > 30);

        foreach (var item in filteredPeople)
        {
            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.Age}");
        }

        //find average age
        double averageAge = people.Average(p => p.Age);
        Console.WriteLine($"Average Age: {averageAge}");

        Console.ReadKey();
    }
}
