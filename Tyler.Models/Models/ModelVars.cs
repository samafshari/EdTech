using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler;

public static class ModelVars
{
    public const string SpriteSheetsDirectoryName = "Assets";
    public const int MaskTopLeft = 0b1000_0000;
    public const int MaskTopRight = 0b0100_0000;
    public const int MaskBottomLeft = 0b0010_0000;
    public const int MaskBottomRight = 0b0001_0000;
    public const int MaskTop = 0b0000_1000;
    public const int MaskBottom = 0b0000_0100;
    public const int MaskLeft = 0b0000_0010;
    public const int MaskRight = 0b0000_0001;
    public const int SideBackground = 0b0001_0000_0000_0000_0000;
    public const int SideForeground = 0b0010_0000_0000_0000_0000;
    public const int SideDecal = 0;
    public const int DefaultBitMask = 0b1111_1111_0000_0000;
}
