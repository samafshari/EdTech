using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Tile : IDiffable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public long Id { get; set; }
        public int[]? Tags { get; set; }
        public uint Handle { get; set; } 
        public string? Script { get; set; }
        public string? BrushId { get; set; }
        public uint? AutoHandle { get; set; }
        public string? AutoBrushId { get; set; }
        public float TimeOffset { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
        public TileCollisionOverride Collision { get; set; }
        public bool ReplaceTileDefTags { get; set; }
    }
}
