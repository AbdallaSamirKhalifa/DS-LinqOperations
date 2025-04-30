using System;
using System.Collections.Generic;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        MinHeapPriorityQueue pq = new MinHeapPriorityQueue();

        Console.WriteLine("Inserting elements into the Priority Queue:");
        Console.WriteLine("Inserting (Task 1, 5)");
        Console.WriteLine("Inserting (Task 2, 3)");
        Console.WriteLine("Inserting (Task 3, 4)");
        Console.WriteLine("Inserting (Task 4, 1)");
        Console.WriteLine("Inserting (Task 5, 2)");

            
        pq.Insert("Task 1", 5);
        pq.Insert("Task 2", 3);
        pq.Insert("Task 3", 4);
        pq.Insert("Task 4", 1);
        pq.Insert("Task 5", 2);

        Console.WriteLine($"\nPeed the minimum priority element: {pq.Peek().ToString()}");

        Console.WriteLine("\nExtracting elements from the priority queue:");

        while (pq.Count > 0)
        {
            Console.WriteLine($"\nExtracted Element: {pq.ExtractMin().ToString()}");
        }
        Console.ReadKey();
    }
}

