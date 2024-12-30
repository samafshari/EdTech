using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public enum RuleBrushType
    {
        [Display(Name = "Single")] Single,
        [Display(Name = "Terrain 4x4")] Terrain4x4,
        [Display(Name = "Terrain 48")] Terrain48,
        [Display(Name = "Terrain (Custom)")] TerrainCustom,
        AutoBrush
    }
}
