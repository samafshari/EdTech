using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public class WorldState : IDiffable
{
    public int SelectedTabIndex { get; set; }
    public bool IsSpriteBrushActive { get; set; }
    //public string? Path { get; set; }
    //public string? PackagePath { get; set; }

    // SPRITE SHEETS AND SPRITES
    public string? SelectedSpriteSheetId { get; set; }
    public Dictionary<string, SpriteSheetState> SpriteSheet { get; set; } = [];
    public Dictionary<string, SpriteState> Sprite { get; set; } = [];

    // TILE DEFS
    public string? SelectedTileDefSpriteId { get; set; }
    public string? SelectedTileDefId { get; set; }
    //public Dictionary<string, TileDefState> TileDef { get; set; } = [];

    // RULE BRUSHES
    public string? SelectedRuleBrushId { get; set; }
    public bool RuleBrushesShowBitMask { get; set; } = true;
    public Dictionary<string, RuleBrushState> RuleBrush { get; set; } = [];

    // PATTERNS
    public string? SelectedPatternId { get; set; }
    public Dictionary<string, PatternState> Pattern { get; set; } = [];


    // FOLDERS

    // LEVELS
    public string? SelectedLevelId { get; set; }
    public Dictionary<string, LevelState> Level { get; set; } = [];
    public string? SelectedAssetId { get; set; }

    // MAPS
    public string? SelectedMapId { get; set; }
    public Dictionary<string, MapState> Map { get; set; } = [];

    // BITMAP EFFECTS
    public string? SelectedBitmapEffectsPresetId { get; set; }

    // THICK BRUSH
    public ThickBrushDef? CurrentThickBrush { get; set; }

    // TOOL GROUPS
    public Dictionary<Tools, Tools>? LastSelectedTool { get; set; }


    public WorldState DeepCopy()
    {
        return new WorldState
        {
            SelectedTabIndex = SelectedTabIndex,
            //Path = Path,
            //PackagePath = PackagePath,
            SelectedSpriteSheetId = SelectedSpriteSheetId,
            SpriteSheet = SpriteSheet.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            Sprite = Sprite.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedTileDefSpriteId = SelectedTileDefSpriteId,
            SelectedTileDefId = SelectedTileDefId,
            //TileDef = TileDef.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedRuleBrushId = SelectedRuleBrushId,
            RuleBrushesShowBitMask = RuleBrushesShowBitMask,
            RuleBrush = RuleBrush.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedPatternId = SelectedPatternId,
            Pattern = Pattern.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedLevelId = SelectedLevelId,
            Level = Level.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedAssetId = SelectedAssetId,
            SelectedMapId = SelectedMapId,
            Map = Map.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            SelectedBitmapEffectsPresetId = SelectedBitmapEffectsPresetId,
            CurrentThickBrush = CurrentThickBrush,
            LastSelectedTool = LastSelectedTool?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            IsSpriteBrushActive = IsSpriteBrushActive,
        };
    }
}

public abstract class AssetState
{
    public string? Id;
}

public class SpriteSheetState : AssetState
{
    public string? SelectedSpriteId { get; set; }
    public float ScrollX { get; set; }
    public float ScrollY { get; set; }
}

public class SpriteState : AssetState
{

}

public class TileDefState : AssetState
{

}

public class RuleBrushState : AssetState
{

}

public class FolderState : AssetState
{
    public string? IconAsset { get; set; }
}

public class LevelState : AssetState
{
    public string? SelectedChildId { get; set; }
    public bool IsAutoBrushUpdateEnabled { get; set; } = true;
    public float ScrollPercentX { get; set; }
    public float ScrollPercentY { get; set; }
}

public class MapState : AssetState
{
    public string? SelectedChildId { get; set; }
    public float ScrollX { get; set; }
    public float ScrollY { get; set; }
}
