using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyler.Models;

namespace Tyler
{
    public static class CompactTilesExtensions
    {
        public static int ToInt(this bool value) => value ? 1 : 0;
        public static bool ToBool(this int value) => value != 0;

        public static void CompactTiles(this Board b)
        {
            Dictionary<uint, string> idMap = [];
            Dictionary<string, uint> revIdMap = [];
            uint next = 1;

            uint TryAdd(string? s)
            {
                if (s == null)
                    return 0;
                if (!revIdMap.TryGetValue(s, out var olKey))
                {
                    revIdMap[s] = next;
                    idMap[next] = s;
                    return next++;
                }
                return olKey;
            }

            List<string> compactTiles = [];
            foreach (var tile in b.Tiles.OrderBy(t => t.Y).ThenBy(t => t.X))
            {
                var tags = "";
                if (tile.Tags != null)
                {
                    tags = string.Join("_", tile.Tags);
                }
                string[] split = [
                    tile.X.ToString(),
                    tile.Y.ToString(),
                    tile.Handle.ToString(),
                    TryAdd(tile.Script).ToString(),
                    TryAdd(tile.BrushId).ToString(),
                    tile.AutoHandle?.ToString() ?? "",
                    TryAdd(tile.AutoBrushId).ToString(),
                    tile.TimeOffset.ToString(),
                    TryAdd(tile.Name).ToString(),
                    ((int)tile.Collision).ToString(),
                    tags,
                    tile.Id.ToString(),
                    tile.ReplaceTileDefTags.ToInt().ToString()
                ];
                compactTiles.Add(string.Join(",", split));
            }

            b.CompactTiles = compactTiles;
            b.CompactIdMap = idMap;
            b.Tiles = [];
        }

        public static void ExpandTiles(this Board b)
        {
            if (b.CompactIdMap == null || b.CompactTiles == null) return;
            List<Tile> tiles = b.Tiles ?? new List<Tile>();

            string? TryGetString(string? keyStr)
            {
                if (string.IsNullOrWhiteSpace(keyStr))
                    return null;

                if (!uint.TryParse(keyStr, out var key))
                    return default;

                if (key == 0)
                    return null;

                if (!b.CompactIdMap.TryGetValue(key, out var value))
                    return default;

                return value;
            }

            int[]? TryGetIntArr(string? str)
            {
                if (string.IsNullOrWhiteSpace(str))
                    return null;

                return str.Split('_').Select(int.Parse).ToArray();
            }

            uint? TryGetUInt(string? keyStr)
            {
                if (string.IsNullOrWhiteSpace(keyStr))
                    return null;

                if (!uint.TryParse(keyStr, out var key))
                    return default;

                return key;
            }
            
            int TryGetInt(string? keyStr)
            {
                if (string.IsNullOrWhiteSpace(keyStr))
                    return default;

                if (!int.TryParse(keyStr, out var key))
                    return default;

                return key;
            }

            long TryGetLong(string? s)
            {
                if (string.IsNullOrWhiteSpace(s))
                    return 0;

                if (long.TryParse(s, out var l))
                    return l;

                return 0;
            }

            foreach (var line in b.CompactTiles)
            {
                string[] split = line.Split(',');
                Tile tile = new Tile
                {
                    X = int.Parse(split[0]),
                    Y = int.Parse(split[1]),
                    Handle = uint.Parse(split[2]),
                    Script = TryGetString(split[3]),
                    BrushId = TryGetString(split[4]),
                    AutoHandle = TryGetUInt(split[5]),
                    AutoBrushId = TryGetString(split[6]),
                    TimeOffset = float.Parse(split[7]),
                    Name = TryGetString(split[8]),
                    Collision = (TileCollisionOverride)int.Parse(split[9]),
                    Tags = TryGetIntArr(split.ElementAtOrDefault(10)),
                    Id = TryGetLong(split.ElementAtOrDefault(11)),
                    ReplaceTileDefTags = TryGetInt(split.ElementAtOrDefault(12)).ToBool()
                };
                tiles.Add(tile);
            }
            b.Tiles = tiles;
            b.CompactTiles = null;
        }
    }
}
