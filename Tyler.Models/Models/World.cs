using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class World : IDiffable
    {
        public SpriteSheet[] SpriteSheets { get; set; } = [];
        public Level[] Levels { get; set; } = [];
        public TileDef[] TileDefs { get; set; } = [];
        public RuleBrush[] RuleBrushes { get; set; } = [];
        public Folder[] Folders { get; set; } = [];
        public Pattern[] Patterns { get; set; } = [];
        public BitmapEffectsPreset[] BitmapEffectsPresets { get; set; } = [];
        public DataTypes DataTypes { get; set; } = new();

        public int Width { get; set; } = 100;
        public int Height { get; set; } = 100;
        public int TileWidth { get; set; } = 32;
        public int TileHeight { get; set; } = 32;

        public WorldState WorldState { get; set; } = new ();
        public bool NoAssets { get; set; }
        public string? Name { get; set; }
        public string? FileId { get; set; }

        public string? Build { get; set; }
        public string[]? Extern { get; set; }
    }
}
