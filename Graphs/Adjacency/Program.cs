using System;
using System.Collections.Generic;



internal class Program
{
    static void Main(string[] args)
    {
        //First example
        List<string> vertices = new List<string>() { "A", "B", "C", "D", "E" };

        Graph graph1 = new Graph(vertices,Graph.enGraphDirectionType.Undirected);

        graph1.AddEdge("A", "B", 1);
        graph1.AddEdge("A", "C", 1);
        graph1.AddEdge("B", "D", 1);
        graph1.AddEdge("C", "D", 1);
        graph1.AddEdge("B", "E", 1);
        graph1.AddEdge("D", "E", 1);

        graph1.DisplayGraph("Adjacency matrix for Example 1 (Undirected Graph)");

        Console.WriteLine("\n------------------------------\n");

        //------------------------------------------------------------------------------------
        //Seconed exmaple
        Graph graph2 = new Graph(vertices, Graph.enGraphDirectionType.Directed);

        graph2.AddEdge("A", "A", 1);
        graph2.AddEdge("A", "B", 1);
        graph2.AddEdge("A", "C", 1);
        graph2.AddEdge("B", "E", 1);
        graph2.AddEdge("D", "B", 1);
        graph2.AddEdge("D", "C", 1);
        graph2.AddEdge("D", "E", 1);

        graph2.DisplayGraph("Adjacency matrix for Example2 (Directed Graph");

        Console.WriteLine($"\nInDegree of vertix D: {graph2.GetInDegree("D")}");
        Console.WriteLine($"\nOutDegree of vertix D: {graph2.GetOutDegree("D")}");
        Console.WriteLine("\n------------------------------\n");


        //------------------------------------------------------------------------------------
        //Seconed exmaple
        Graph graph3 = new Graph(vertices, Graph.enGraphDirectionType.Undirected);

        graph3.AddEdge("A", "B", 5);
        graph3.AddEdge("A", "C", 3);
        graph3.AddEdge("B", "D", 12);
        graph3.AddEdge("C", "D", 10);
        graph3.AddEdge("B", "E", 2);
        graph3.AddEdge("D", "E", 7);


        graph3.DisplayGraph("Adjacency matrix for Exmaple3 (Weighted Graph)");

        Console.WriteLine($"\nIs there an edge between A and B in Graph3: {graph3.IsEdge("A", "B")}");
        Console.WriteLine($"\nIs there an edge between B and C in Graph3: {graph3.IsEdge("B", "C")}");
        Console.WriteLine($"\nIs there an edge between E and D in Graph3: {graph3.IsEdge("E", "D")}");

        Console.WriteLine($"\nInDegree of vertix A: {graph3.GetInDegree("A")}");
        Console.WriteLine($"\nOutDegree of vertix A: {graph3.GetOutDegree("A")}");
        Console.WriteLine("\n------------------------------\n");

        Console.WriteLine("\nRemovign an edge between E and D:\n");
        graph3.RemoveEdge("E", "D");
        graph3.DisplayGraph("After removing edge between E and D");
        Console.WriteLine($"\nIs there an edge between E and D in Graph3: {graph3.IsEdge("E", "D")}");

        Console.ReadKey();
    }
}

