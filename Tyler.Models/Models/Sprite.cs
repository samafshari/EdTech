using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Sprite : Asset
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public string? SpriteBrushId { get; set; }
        public int[] BitMasks { get; set; } = [];
        public bool IsActive { get; set; }
        public bool IsMarkedForRuleExport { get; set; } = true;
    }
}
