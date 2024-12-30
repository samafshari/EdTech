using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class BrushRuleTile : IDiffable
    {
        public double Probability { get; set; } = 1;
        public string? AssetId { get; set; }
    }
}
