using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class AutoTerrainSide : IDiffable
    {
        public string? SpriteId { get; set; }
        public TileMode Tile { get; set; }
        public double TileX { get; set; }
        public double TileY { get; set; }
        public double U { get; set; }
        public double V { get; set; }
        public double Rotation { get; set; }
        public bool IsActive { get; set; }

        public static AutoTerrainSide Clone(AutoTerrainSide side)
        {
            return new AutoTerrainSide
            {
                SpriteId = side.SpriteId,
                Tile = side.Tile,
                TileX = side.TileX,
                TileY = side.TileY,
                U = side.U,
                V = side.V,
                Rotation = side.Rotation,
                IsActive = side.IsActive
            };
        }

        public AutoTerrainSide Clone()
        {
            return Clone(this);
        }
    }
}
