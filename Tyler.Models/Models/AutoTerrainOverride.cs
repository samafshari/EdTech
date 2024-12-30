using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class AutoTerrainOverride : IDiffable
    {
        public AutoTerrainSide? Background { get; set; }
        public AutoTerrainSide? Foreground { get; set; }
        public AutoTerrainSide? Decal { get; set; }
    }
}
