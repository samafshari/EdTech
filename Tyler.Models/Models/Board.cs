using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Board : Thing, IVarsAndComponentsModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Tile> Tiles { get; set; } = new List<Tile>();
        public List<string>? CompactTiles { get; set; }
        public Dictionary<uint, string>? CompactIdMap { get; set; }
        public string? BeforeScript { get; set; }
        public string? AfterScript { get; set; }
        public uint BackgroundColor { get; set; }
        public float Opacity { get; set; } = 1.0f;
        public uint TintColor { get; set; } 
        public int BlendModeId { get; set; } 
        public int GapWidth { get; set; }
        public int GapHeight { get; set; }
        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public int GridMinorStopsX { get; set; } 
        public int GridMajorStopsX { get; set; } 
        public int GridMinorStopsY { get; set; } 
        public int GridMajorStopsY { get; set; } 
        public int AutoBrushIterations { get; set; } = 1;
        public int Seed { get; set; }
        public AutoBrushRegion[] AutoBrushRegions { get; set; } = [];
        public TileCollisionOverride Collision { get; set; }
        public BoardStamp[]? Stamps { get; set; }
        public PolygonCollection[]? Walls { get; set; }
        public bool IsKiloTexture { get; set; }
        public Variable[]? Variables { get; set; }
        public DataComponent[]? DataComponents { get; set; }
        [JsonIgnore] public long DataContainerId { get; set; }
    }

    public class BoardStamp
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public string? SpriteId;
    }

    public class PolygonCollection
    {
        public Float2[] Polygon { get; set; } = [];
    }
}
