using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class BrushRuleCondition : IDiffable
    {
        public int DX { get; set; }
        public int DY { get; set; }
        public LogicGate Gate { get; set; }
        public string? Is { get; set; }
        public BrushRuleCondition[] Children { get; set; } = Array.Empty<BrushRuleCondition>();
    }
}
