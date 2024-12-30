using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

[Flags]
public enum DrawableAssetTypes
{
    None = 0,
    RuleBrush = 1,
    Pattern = 2,
    TileDef = 4,
    Sprite = 8,
    SpriteSheet = 16,
    Folder = 32,
    All = RuleBrush | TileDef | Sprite | SpriteSheet | Pattern
}
