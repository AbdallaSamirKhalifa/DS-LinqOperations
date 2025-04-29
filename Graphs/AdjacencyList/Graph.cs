using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Security;



public class Graph
{
     public enum enGraphDirection { Directed, UnDirected}

    //dictionary to store the adjacency list (vertex -> list of edges)
    private Dictionary<string, List<(string Vertex, int Weight)>> _adjacencyList;

    //dictionary to map string vertices to their neighbors
    private Dictionary<string, int> _vertexDictionary;
    private int _numberOfVertices;
    private enGraphDirection _GraphDirection = enGraphDirection.UnDirected;

    public Graph(List<string> vertices, enGraphDirection direction)
    {
        _GraphDirection = direction;
        _numberOfVertices = vertices.Count;

        _adjacencyList = new Dictionary<string, List<(string Vertex, int Weight) >>();

        _vertexDictionary = new Dictionary<string, int>();
        for (int i = 0; i < _numberOfVertices; i++)
        {
            _vertexDictionary[vertices[i]] = i;
            _adjacencyList[vertices[i]] = new List<(string Vertex, int Weight)>();//initialization of an empty list

        }
    }

    public void AddEdge(string source, string destination, int weight)
    {
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            _adjacencyList[source].Add((Vertex: destination,Weight: weight));

            if (_GraphDirection is enGraphDirection.UnDirected)
                _adjacencyList[destination].Add((Vertex: source,Weight: weight));

        }
        else
            Console.WriteLine($"\n\nIgnored: invalid vertices {source} ==> {destination}\n\n");
    }

    public void RemoveEdge(string source, string destination)
    {
        if(_vertexDictionary.ContainsKey(source)&& _vertexDictionary.ContainsKey(destination))
        {
            _adjacencyList[source].RemoveAll(edge => edge.Vertex == destination);

            if (_GraphDirection is enGraphDirection.UnDirected)
                _adjacencyList[destination].RemoveAll(edge => edge.Vertex == source);
        }
        else
            Console.WriteLine($"\n\ninvalid vertices {source} ==> {destination}\n\n");
    } 

    public void DisplayGraph(string Message)
    {
        Console.WriteLine($"\n{Message}\n");

        foreach (var vertex in _adjacencyList)
        {
            Console.Write($"{vertex.Key} -> ");

            vertex.Value.ForEach(edge => Console.Write($"{edge.Vertex}({edge.Weight}) "));
            Console.WriteLine();
        }
    }

    //to check if there is an edge between two vertices
    public bool IsEdge(string source, string destination)
    {
        if( _vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            foreach (var edge in _adjacencyList[source])
            {
                if (edge.Vertex == destination)
                    return true;
            }
        }
        return false;
    }

    public int GetInDegree(string vertex)
    {
        int InDegree = 0;
        if (_vertexDictionary.ContainsKey(vertex))
        {
            foreach (var source in _adjacencyList)
            {
                foreach(var edge in source.Value)
                {
                    if (edge.Vertex == vertex) InDegree++;
                }
            }
        }
        return InDegree;
    }

    public int GetOutDegree(string vertex)
    {
        if (_vertexDictionary.ContainsKey(vertex))
            return _adjacencyList[vertex].Count;
        else
            return 0;
    }
}

