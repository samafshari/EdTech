using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public enum TileCollisionMode
    {
        None = 0,
        Solid = 1,
        Trigger = 2,
        OneWay = 3,
        OptimizedWall = 4
    }

    public enum TileCollisionOverride
    {
        Default = 0,
        Ignore = 2,
        Wall = 1,
        OptimizedWall = 3
    }

    public static class TileCollisionModeExtensions
    {
        public static TileCollisionMode CalculateCollisionMode(this TileCollisionMode mode, TileCollisionOverride board, TileCollisionOverride tile)
        {
            if (board == TileCollisionOverride.OptimizedWall) return TileCollisionMode.OptimizedWall;
            if (tile == TileCollisionOverride.OptimizedWall) return TileCollisionMode.OptimizedWall;
            if (board == TileCollisionOverride.Ignore) return TileCollisionMode.None;
            if (tile == TileCollisionOverride.Ignore) return TileCollisionMode.None;
            if (mode == TileCollisionMode.OptimizedWall) return TileCollisionMode.OptimizedWall;
            if (board == TileCollisionOverride.Wall) return TileCollisionMode.Solid;
            if (tile == TileCollisionOverride.Wall) return TileCollisionMode.Solid;
            return mode;
        }

        public static TileCollisionMode CalculateCollisionMode(this TileCollisionMode mode, TileCollisionOverride o)
        {
            if (o == TileCollisionOverride.OptimizedWall) return TileCollisionMode.OptimizedWall;
            if (o == TileCollisionOverride.Ignore) return TileCollisionMode.None;
            if (o == TileCollisionOverride.Wall) return TileCollisionMode.Solid;
            return mode;
        }
    }
}
