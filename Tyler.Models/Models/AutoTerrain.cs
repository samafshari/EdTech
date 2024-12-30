using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class AutoTerrain : IDiffable
    {
        public const double DefaultCutOff = 1;
        public const double DefaultCornerRadius = 4;
        public const double DefaultInnerCornerRadius = 3;

        public static double[] DefaultCutOffArray => [DefaultCutOff, DefaultCutOff, DefaultCutOff, DefaultCutOff];
        public static double[] DefaultCornerRadiusArray => [DefaultCornerRadius, DefaultCornerRadius, DefaultCornerRadius, DefaultCornerRadius];
        public static double[] DefaultInnerCornerRadiusArray => [DefaultInnerCornerRadius, DefaultInnerCornerRadius, DefaultInnerCornerRadius, DefaultInnerCornerRadius];

        public double[] CornerRadiuses { get; set; } = new double[4];
        public double[] InnerCornerRadiuses { get; set; } = new double[4];
        public bool InvertOuterCorners { get; set; }
        public bool InvertInnerCorners { get; set; }
        public double[] CutOffs { get; set; } = new double[4];

        public int TileWidth { get; set; }
        public int TileHeight { get; set; }
        public Dictionary<int, AutoTerrainSide> Sides { get; set; } = [];
        public Dictionary<int, AutoTerrainOverride> Overrides { get; set; } = [];
        public static Dictionary<int, AutoTerrainSide> MakeSidesWithForegroundSpriteId(string? spriteId)
        {
            return new Dictionary<int, AutoTerrainSide>
            {
                [ModelVars.SideBackground] = new()
                {
                    IsActive = false,
                    SpriteId = null,
                },
                [ModelVars.SideForeground] = new()
                {
                    IsActive = true,
                    SpriteId = spriteId,
                },
                [ModelVars.MaskLeft] = new(),
                [ModelVars.MaskRight] = new(),
                [ModelVars.MaskTop] = new(),
                [ModelVars.MaskBottom] = new()
            };
        }
    }
}
