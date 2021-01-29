using System;

namespace Equality
{
    public class PointC : IEquatable<PointC>
    {
        public int X { get; init; }
        public int Y { get; init; }

        public bool Equals(PointC other)
        {
            Console.WriteLine("Calling Equals");

            return other != null && this.GetType() == other.GetType() && X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PointC);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Calling GetHashCode");

            HashCode hash = new HashCode();

            hash.Add(X);
            hash.Add(Y);

            return hash.ToHashCode();
        }
    }

    public struct PointS 
    {
        public int X { get; init; }
        public int Y { get; init; }
    }

    public record PointR
    {
        public int X { get; init; }
        public int Y { get; init; }
    }
}
