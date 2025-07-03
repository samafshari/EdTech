using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class SpriteKeyFrame : IDiffable
    {
        public string? SpriteId { get; set; }
        public double Duration { get; set; }
        public double DurationMax { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }
    }
}
