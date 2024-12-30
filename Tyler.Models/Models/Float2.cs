using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public struct Float2 : IDiffable
    {
        public float X;
        public float Y;

        public Float2() { }
        public Float2(float x, float y) { X = x; Y = y; }
        public Float2((float X, float Y) args) : this(args.X, args.Y) { }

        public static implicit operator Float2((float X, float Y) args) => new(args);
        public static implicit operator (float X, float Y)(Float2 args) => (args.X, args.Y);

        public static Float2 operator +(Float2 a, Float2 b) => new(a.X + b.X, a.Y + b.Y);
        public static Float2 operator -(Float2 a, Float2 b) => new(a.X - b.X, a.Y - b.Y);
        public static Float2 operator *(Float2 a, Float2 b) => new(a.X * b.X, a.Y * b.Y);
        public static Float2 operator /(Float2 a, Float2 b) => new(a.X / b.X, a.Y / b.Y);
        public static Float2 operator %(Float2 a, Float2 b) => new(a.X % b.X, a.Y % b.Y);
        public static bool operator == (Float2 a, Float2 b) => a.X == b.X && a.Y == b.Y;
        public static bool operator != (Float2 a, Float2 b) => a.X != b.X || a.Y != b.Y;

        public readonly override bool Equals(object? obj)
        {
            if (obj is Float2 other)
                return X == other.X && Y == other.Y;
            if (obj is Tuple<float, float> tuple)
                return X == tuple.Item1 && Y == tuple.Item2;
            return false;
        }

        public readonly override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public readonly override string ToString()
        {
            return $"({X}, {Y})";
        }

        public float[] ToArray() => new float[] { X, Y };
    }
}
