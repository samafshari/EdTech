using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public struct RectF
    {
        public float Left { get; set; }
        public float Top { get; set; }
        public float Right { get; set; }
        public float Bottom { get; set; }

        public RectF() { }

        public RectF(float left, float top, float right, float bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public readonly bool IzZero() => Left == 0 && Top == 0 && Right == 0 && Bottom == 0;
        public readonly bool HasValue() => Left != 0 || Top != 0 || Right != 0 || Bottom != 0;
        public readonly override string ToString()
        {
            return $"({Left}f, {Top}f, {Right}f, {Bottom}f)";
        }
    }
}
