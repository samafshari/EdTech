using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public enum TileAnchor
    {
        TopLeft,
        TopCenter,
        TopRight,
        MiddleLeft,
        MiddleCenter,
        MiddleRight,
        BottomLeft,
        BottomCenter,
        BottomRight
    }

    public static class TileAnchorExtensions
    {
        public static Float2 GetAnchorFactors(this TileAnchor anchor)
        {
            return anchor switch
            {
                TileAnchor.TopLeft => new Float2(0, 0),
                TileAnchor.TopCenter => new Float2(0.5f, 0),
                TileAnchor.TopRight => new Float2(1, 0),
                TileAnchor.MiddleLeft => new Float2(0, 0.5f),
                TileAnchor.MiddleCenter => new Float2(0.5f, 0.5f),
                TileAnchor.MiddleRight => new Float2(1, 0.5f),
                TileAnchor.BottomLeft => new Float2(0, 1),
                TileAnchor.BottomCenter => new Float2(0.5f, 1),
                TileAnchor.BottomRight => new Float2(1, 1),
                _ => new Float2(0, 0)
            };
        }
    }

    public class TileDef : Asset, IVarsAndComponentsModel
    {
        public string? Name { get; set; }
        public string? BasedOn { get; set; }
        public char Char { get; set; }
        public string? Script { get; set; }
        public TileAnimation? Animation { get; set; }
        public bool OverrideSize { get; set; }
        public int OverrideWidth { get; set; }
        public int OverrideHeight { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public float RowSpan { get; set; } = 1;
        public float ColSpan { get; set; } = 1;
        public uint BackgroundColor { get; set; }
        public uint TintColor { get; set; } = 0xFFFFFFFF;
        public string? Text { get; set; }
        public Variable[]? Variables { get; set; }
        public DataComponent[]? DataComponents { get; set; }
        public TileAnchor Anchor { get; set; }
        [JsonIgnore] public long DataContainerId { get; set; }

        public TileCollisionMode CollisionMode { get; set; }
        public TileFlags TileFlags { get; set; }
        public PhysicsSimulationMode PhysicsSimulationMode { get; set; }
        public float GravityMultiplierX { get; set; }
        public float GravityMultiplierY { get; set; }
        public int[]? Tags { get; set; }
        public int LayerId { get; set; }
        public RectF ColliderPadding { get; set; }
    }
}
