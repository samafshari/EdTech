using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyler.Models;

namespace Tyler
{
    public static class WorldExtensions
    {
        public static IEnumerable<IStringRecord> GetRecords(this World world)
        {
            return world.RuleBrushes.Cast<IStringRecord>()
                .Union(world.Folders)
                .Union(world.TileDefs)
                .Union(world.SpriteSheets)
                .Union(world.SpriteSheets.SelectMany(x => x.Sprites))
                .Union(world.Patterns)
                .Union(world.Levels)
                .Union(world.Levels.SelectMany(x => x.Quads))
                .Union(world.Levels.SelectMany(x => x.Boards));
        }

        public static bool IsAnimated(this TileDef tileDef)
        {
            return 
                tileDef.Animation != null &&
                tileDef.Animation.Mode != AnimationMode.None &&
                tileDef.Animation.KeyFrames != null &&
                tileDef.Animation.KeyFrames.Length > 1;
        }

        public static SpriteKeyFrame? GetFirstFrame(this TileDef tileDef)
        {
            return tileDef.Animation?.KeyFrames?.FirstOrDefault();
        }
    }
}
