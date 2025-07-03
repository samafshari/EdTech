using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class BrushRule : IDiffable
    {
        public int Dx { get; set; }
        public int Dy { get; set; }
        public BrushRuleTile[]? Tiles { get; set; }
        public BrushRuleCondition? Condition { get; set; }
        public int Bits { get; set; }
        public int Mask { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDefault { get; set; }
    }
}
