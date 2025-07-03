using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Settings : IDiffable
    {
        public string? LastOpenedPNGPath { get; set; }
        public string? LastWorldPath { get; set; }
        public string? BackgroundColor { get; set; }
        public int TileWidth { get; set; } = 32;
        public int TileHeight { get; set; } = 32;
        public int WorldWidth { get; set; } = 100;
        public int WorldHeight { get; set; } = 100;
        public List<string> Spritesheets { get; set; } = new List<string>();
        public bool IsSoloMode { get; set; } = true;
        public FocusMode FocusMode { get; set; } = FocusMode.OnionAbove;
        public double DimOpacity { get; set; } = 0.2;
        public double RuleOpacity { get; set; } = 0.5;
        public double BrushColorOpacity { get; set; } = 0.0;

        public bool ToggleBitMaskIndicatorsInQuickTerrain { get; set; } = false;
        public bool ShowBrushNameInPalette { get; set; } = true;
        public bool ShowOtherSpritesFromSameBrush { get; set; } = true;
        public bool ToggleXRay { get; set; } = false;

        public int GridVisibility { get; set; } = 2;
        public bool IsTouchDrawEnabled { get; set; }
        public bool SmallPaletteIcons { get; set; }
        public bool ShowKindIcons { get; set; } = true;

        public List<LibrarySaveMetaData> Saves { get; set; } = [];
        public int AutoSaveMinutes { get; set; } = 3;
        public bool HideSavesWithSameName { get; set; } = true;
        public bool IsTileDefSpritesVisible { get; set; } = true;
        public bool IsParallaxEnabled { get; set; } = true;
        public bool IsAutoPolishOnEraseEnabled { get; set; } = true;
        public bool IsAssetPickerToolBarVisible { get; set; } = true;
        public bool IsFullScreen { get; set; } = true;

        public string? LastSaveId { get; set; }
        public bool IsUnityVisible { get; set; } = true;
        public TileRenderMode TileRenderMode { get; set; } = TileRenderMode.TileDefAndColliders;
        public bool IsColliderBrushAffectsRuleBrush { get; set; } = true;
        public TileCollisionMode ColliderBrushMode { get; set; } = TileCollisionMode.Solid;
        public bool IsColliderBrushInTileDefMode { get; set; } = true;
        public TileCollisionOverride ColliderBrushOverride { get; set; } = TileCollisionOverride.Default;
        public bool IsColliderFillAll { get; set; } = true;

        public bool MuteSoundEffects { get; set; }
        public bool IsRuleTileOverdrawAllowed { get; set; } = true;
        public bool IsBorderAroundTilesVisible { get; set; } = false;
        public TileDefSortMode TileDefSortMode { get; set; } = TileDefSortMode.None;
        public bool IsAnimationsRunning { get; set; } = true;
        public bool IgnoreSizeAndAnchor { get; set; } = false;
    }
}
