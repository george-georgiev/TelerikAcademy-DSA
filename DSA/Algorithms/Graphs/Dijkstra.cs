using Structures.PriorityQueues;
using System.Collections.Generic;

namespace Algorithms.Graphs
{
    public class Dijkstra
    {
        public Dictionary<string, int> FindShortestPaths(Dictionary<string, List<Vertex>> graph, string src)
        {
            var shortestPaths = new Dictionary<string, int>();

            var binaryHeap = new BinaryHeap<Vertex>(graph.Count);
            foreach (var pair in graph)
            {
                if (pair.Key == src)
                {
                    binaryHeap.Enqueue(new Vertex(pair.Key, 0));
                }
                else
                {
                    binaryHeap.Enqueue(new Vertex(pair.Key, int.MaxValue));
                }
            }

            while (binaryHeap.Count != 0)
            {
                var vertex = binaryHeap.Dequeue();
                if (shortestPaths.ContainsKey(vertex.Name))
                {
                    continue;
                }

                shortestPaths.Add(vertex.Name, vertex.Distance);

                foreach (var successor in graph[vertex.Name])
                {
                    if (shortestPaths.ContainsKey(successor.Name))
                    {
                        continue;
                    }

                    var dist = vertex.Distance + successor.Distance;
                    binaryHeap.Enqueue(new Vertex(successor.Name, dist));
                }
            }

            return shortestPaths;
        }
    }
}
