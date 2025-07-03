using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Quad : Thing
    {
        public string? SpriteId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public TileMode Tile { get; set; }
        public float TileX { get; set; }
        public float TileY { get; set; }
        public bool TileRelativeCoords { get; set; } = true;
        public float U { get; set; }
        public float V { get; set; }
        public uint Fill { get; set; }
        public uint Tint { get; set; } = 0xFFFFFFFF;
        public float Opacity { get; set; } = 1.0f;
        public int BitmapBlendingModeId { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }
    }
}
