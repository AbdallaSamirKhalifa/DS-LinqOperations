using System;
using System.Collections.Generic;

    public class Graph
    {
        public enum enGraphDirectionType { Directed, Undirected }

        //Adjacency matrix to store the weights of the edges between vertices
        private int[,] _AdjacencyMatrix;

        // Dictionary to map string vertices to interger indices for adgacency matrix
        private Dictionary<string, int> _VerticesDictionary;

        //Number of vertices in the graph
        private int _NumberOfVertices;
        private enGraphDirectionType _Direction = enGraphDirectionType.Undirected;

        public Graph(List<string> vertices, enGraphDirectionType graphDirectionType)
        {
            _Direction = graphDirectionType;

            _NumberOfVertices = vertices.Count;

            _AdjacencyMatrix = new int[_NumberOfVertices, _NumberOfVertices];

            _VerticesDictionary = new Dictionary<string, int>();

            //Populate dictionary with vertices (e.g., 'A' -> 0, 'B' -> 1, etc).
            for (int i = 0; i < vertices.Count; i++)
            {
                _VerticesDictionary[vertices[i]] = i;
            }
        }

        //Method to add a weighted edge between two vertices (Source and Distination))
        public void AddEdge(string Source, string Destination, int weight)
        {
            // Check if both source and destination vertices exist in the map
            if (_VerticesDictionary.ContainsKey(Source) && _VerticesDictionary.ContainsKey(Destination))
            {

                //Retrieve the indices fro the source and destination vertices
                int sourceIndex = _VerticesDictionary[Source];
                int destinationIndex = _VerticesDictionary[Destination];


                //Set the matrix value to the weight for [sourceIndex, destinationIndex]: One-way
                _AdjacencyMatrix[sourceIndex, destinationIndex] = weight;

                //set the matrix value to the weight for [destinatioIndex, sourceIndex] : two way incase its undirected
                if (_Direction is enGraphDirectionType.Undirected)
                    _AdjacencyMatrix[destinationIndex, sourceIndex] = weight;


            }
            else
                Console.WriteLine($"\n\nIgnored: invalid vertices: {Source} ==> {Destination}\n\n");


        }

        public void RemoveEdge(string Source, string Destination)
        {
            // Check if both source and destination vertices exist in the map
            if (_VerticesDictionary.ContainsKey(Source) && _VerticesDictionary.ContainsKey(Destination))
            {

                //Retrieve the indices fro the source and destination vertices
                int sourceIndex = _VerticesDictionary[Source];
                int destinationIndex = _VerticesDictionary[Destination];


                //Set the matrix value to the weight for [sourceIndex, destinationIndex]: One-way
                _AdjacencyMatrix[sourceIndex, destinationIndex] = 0;

                //set the matrix value to the weight for [destinatioIndex, sourceIndex] : two way incase its undirected
                if (_Direction is enGraphDirectionType.Undirected)
                    _AdjacencyMatrix[destinationIndex, sourceIndex] = 0;


            }
            else
                Console.WriteLine($"\n\nIgnored: invalid vertices: {Source} ==> {Destination}\n\n");
        }

        public void DisplayGraph(string Message)
        {
            Console.WriteLine($"\n{Message}\n ");

            //Print the header row 
            foreach (var vertex in _VerticesDictionary.Keys)
            {
                Console.Write("  "+vertex );
            }
            Console.WriteLine();

            foreach (var source in _VerticesDictionary)
            {
                Console.Write(source.Key + " ");
                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    Console.Write(_AdjacencyMatrix[source.Value, i] + "  ");
                }
                Console.WriteLine();
            }
        }

        public bool IsEdge(string Source, string Destination)
        {
            if (_VerticesDictionary.ContainsKey(Source) && _VerticesDictionary.ContainsKey(Destination))
                return _AdjacencyMatrix[_VerticesDictionary[Source], _VerticesDictionary[Destination]] > 0;
            else
                return false;
        }

        public int GetOutDegree(string vertex)
        {
            int degree = 0;
            if (_VerticesDictionary.ContainsKey(vertex))
            {
                int vertexIndex = _VerticesDictionary[vertex];
                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    if (_AdjacencyMatrix[vertexIndex, i] > 0)
                        degree++;
                }
            }
            return degree;
        }

        public int GetInDegree(string vertex)
        {
            int degree = 0;
            if (_VerticesDictionary.ContainsKey(vertex))
            {
                int vertexIndex = _VerticesDictionary[vertex];
                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    if (_AdjacencyMatrix[i, vertexIndex] > 0)
                        degree++;
                }
            }
            return degree;
        }

    }

