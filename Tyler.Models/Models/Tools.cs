using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler;

public enum Tools
{
    Select,
    Move,
    Pick,
    Draw,
    Erase,
    FloodFill,
    Pan,
    RectSelect,
    EllipseSelect,
    RectDraw,
    EllipseDraw,
    ModifyGrid,
    MagicWand,
    AutoBrushRegion,
    ThickBrushDraw,
    ThickErase,
    ThickSelect,
    ThickPolish,
    ThickColliderDraw,
}

public enum ThickBrushActions
{
    Draw,
    Erase,
    Select,
    Deselect,
    Polish,
    ColliderDraw,
}
