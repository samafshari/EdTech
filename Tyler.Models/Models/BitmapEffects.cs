using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public enum BitmapEffectType
{
    RemoveColor,
    ReplaceColor,
    Op,
    Grayscale,
    HSV,
    BrightnessContrast
}

public enum BitmapEffectOp
{
    Multiply,
    Add,
    Subtract
}

public class BitmapEffects
{
    public uint RemoveColor { get; set; }

    public BitmapEffect[] Effects { get; set; } = [];
}

public class BitmapEffect
{
    public BitmapEffectType BitmapEffectType { get; set; }
    public BitmapEffectOp Op { get; set; }
    public uint Color { get; set; }
    public uint Color2 { get; set; }
    public float Alpha { get; set; } = 1;
    public float F1 { get; set; }
    public float F2 { get; set; }
    public float F3 { get; set; }
    public bool IsEnabled { get; set; }
}
