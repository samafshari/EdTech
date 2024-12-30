using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class SpriteSheet : Asset
    {
        public string? RelativePath { get; set; }
        public string? RenderedPath { get; set; }
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();
        public SpriteSheetType Type { get; set; }
        public AutoTerrain? AutoTerrain { get; set; }
        public string? LevelId { get; set; }
        public BitmapEffects? BitmapEffects { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public PackingGroup PackingGroup { get; set; }
    }
}
