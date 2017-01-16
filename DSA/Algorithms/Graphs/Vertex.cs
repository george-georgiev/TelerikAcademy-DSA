using System;

namespace Algorithms.Graphs
{
    public class Vertex : IComparable<Vertex>
    {
        public Vertex(string name, int distance)
        {
            this.Name = name;
            this.Distance = distance;
        }

        public string Name { get; }

        public int Distance { get; }

        public int CompareTo(Vertex other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Distance.CompareTo(other.Distance);
            }
        }
    }
}
