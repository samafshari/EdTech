using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    [Flags]
    public enum TileRenderMode
    {
        None = 0,
        TileDef = 1,
        Colliders = 2,
        Texts = 4,
        Nodes = 8,
        TileDefAndColliders = TileDef | Colliders | Texts | Nodes,
    }

    public struct TileDefRenderGroup
    {
        public Int2 Pos;
        public TileAnchor Anchor;

        public TileDefRenderGroup(Int2 pos, TileAnchor anchor)
        {
            Pos = pos;
            Anchor = anchor;
        }

        public override bool Equals(object? obj)
        {
            return obj is TileDefRenderGroup group &&
                   Pos.Equals(group.Pos) &&
                   Anchor == group.Anchor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pos, Anchor);
        }

        public static bool operator ==(TileDefRenderGroup left, TileDefRenderGroup right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TileDefRenderGroup left, TileDefRenderGroup right)
        {
            return !(left == right);
        }
    }
}
