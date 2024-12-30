using System;
using System.Numerics;

namespace Tyler.Models
{
    public struct Int2 : IDiffable
    {
        public int X;
        public int Y;

        public int Bits
        {
            readonly get => Y;
            set => Y = value;
        }

        public int Mask
        {
            readonly get => X;
            set => X = value;
        }

        public Int2() { }
        public Int2(int x, int y) { X = x; Y = y; }
        public Int2((int X, int Y) args) : this(args.X, args.Y) { }

        public static Int2 FromBitMask(int bitMask)
        {
            return new Int2 { X = bitMask >> 8, Y = bitMask & 0xff };
        }

        public static implicit operator Int2((int X, int Y) args) => new(args);
        public static implicit operator (int X, int Y)(Int2 args) => (args.X, args.Y);

        public static Int2 operator +(Int2 a, Int2 b) => new(a.X + b.X, a.Y + b.Y);
        public static Int2 operator -(Int2 a, Int2 b) => new(a.X - b.X, a.Y - b.Y);
        public static Int2 operator *(Int2 a, Int2 b) => new(a.X * b.X, a.Y * b.Y);
        public static Int2 operator /(Int2 a, Int2 b) => new(a.X / b.X, a.Y / b.Y);
        public static Int2 operator %(Int2 a, Int2 b) => new(a.X % b.X, a.Y % b.Y);
        public static bool operator ==(Int2 a, Int2 b) => a.X == b.X && a.Y == b.Y;
        public static bool operator !=(Int2 a, Int2 b) => a.X != b.X || a.Y != b.Y;

        public readonly override bool Equals(object? obj)
        {
            if (obj is Int2 other)
                return X == other.X && Y == other.Y;
            if (obj is Tuple<int, int> tuple)
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

        /// <summary>
        /// X: Mask
        /// Y: Bits
        /// </summary>
        /// <returns></returns>
        public readonly int GetBitMask() => X << 8 | Y;

        public readonly ulong ToInt64() => ToInt64(X, Y);
        public static ulong ToInt64(int x, int y) => (ulong)(uint)x << 32 | (ulong)(uint)y;
        public static Int2 FromInt64(ulong k) => new Int2((int)(k >> 32), (int)k);

        public Vector2 ToVector2() => new Vector2(X, Y);
    }
}
