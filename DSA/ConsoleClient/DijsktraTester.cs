using Algorithms.Graphs;
using System;
using System.Collections.Generic;

namespace ConsoleClient
{
    public class DijsktraTester
    {
        public void Test()
        {
            Console.WriteLine("Dijsktra Test");

            var graph = new Dictionary<string, List<Vertex>>();

            graph.Add("0", new List<Vertex> { new Vertex("1", 4), new Vertex("7", 8) });
            graph.Add("1", new List<Vertex> { new Vertex("0", 4), new Vertex("7", 11), new Vertex("2", 8) });
            graph.Add("2", new List<Vertex> { new Vertex("1", 8), new Vertex("3", 7), new Vertex("8", 2), new Vertex("5", 4) });
            graph.Add("3", new List<Vertex> { new Vertex("2", 7), new Vertex("5", 14), new Vertex("4", 9) });
            graph.Add("4", new List<Vertex> { new Vertex("3", 9), new Vertex("5", 10) });
            graph.Add("5", new List<Vertex> { new Vertex("6", 2), new Vertex("2", 4), new Vertex("3", 14), new Vertex("4", 10) });
            graph.Add("6", new List<Vertex> { new Vertex("7", 1), new Vertex("8", 6), new Vertex("5", 2) });
            graph.Add("7", new List<Vertex> { new Vertex("0", 8), new Vertex("1", 11), new Vertex("8", 7), new Vertex("6", 1) });
            graph.Add("8", new List<Vertex> { new Vertex("7", 7), new Vertex("6", 6), new Vertex("2", 2) });

            var dijkstra = new Dijkstra();
            var spt = dijkstra.FindShortestPaths(graph, "0");

            foreach (var pair in spt)
            {
                Console.WriteLine("Distance to vertex {0} is {1}", pair.Key, pair.Value);
            }
        }
    }
}
