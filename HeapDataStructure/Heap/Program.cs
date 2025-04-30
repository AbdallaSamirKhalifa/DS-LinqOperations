using Heap;
using System;
using System.Collections.Generic;



internal class Program
{
    static void Main(string[] args)
    {


        MinHeap minHeap = new MinHeap();
        minHeap.Insert(10);
        minHeap.Insert(4);
        minHeap.Insert(15);
        minHeap.Insert(2);
        minHeap.Insert(8);




        minHeap.DisplayHeap();
        Console.WriteLine($"\nPeek Minimum Element: {minHeap.Peek()}");

        Console.WriteLine($"\nExtracting elements from the min-heap:");
        Console.WriteLine($"\nExtracted Minimum: {minHeap.ExtractMin()}");
        minHeap.DisplayHeap();

        Console.WriteLine($"\nExtracted Minimum: {minHeap.ExtractMin()}");
        minHeap.DisplayHeap();

        //---------------------------------------------------------Max Heap------------------------------

        MaxHeap maxHeap = new MaxHeap();

        Console.WriteLine("\n\nInserting elements into the Max-Heap...\n");
        maxHeap.Insert(10);
        maxHeap.Insert(4);
        maxHeap.Insert(15);
        maxHeap.Insert(2);
        maxHeap.Insert(8);

        // Display the heap after insertion
        maxHeap.DisplayHeap();

        Console.WriteLine("\nPeek Maximum Element: Maximum Element is: " + maxHeap.Peek());

        // Display the heap after insertion, note that the maximum value is not deleted.
        maxHeap.DisplayHeap();

        // Extract elements based on priority
        Console.WriteLine("\nExtracting elements from the Max-Heap:");
        Console.WriteLine("Extracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.WriteLine("\nExtracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.ReadKey();
    }
}

