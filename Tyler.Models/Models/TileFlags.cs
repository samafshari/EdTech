using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

[Flags]
public enum TileFlags
{
    None = 0,
    Player = 1,
    Type0 = 1 << 2,
    Type1 = 1 << 3,
    Type2 = 1 << 4,
    Type3 = 1 << 5,
    Type4 = 1 << 6,
    Disregard = 1 << 7,
    NamedTileDef = 1 << 8,
    Preserve = 1 << 9,
    GenerateId = 1 << 10,
    CanRotate = 1 << 11,
    PositionLockX = 1 << 12,
    PositionLockY = 1 << 13,
    Simulate = 1 << 14,
    SpriteAutoSizeOff = 1 << 15,
    MimicSize = 1 << 16,
    Save = 1 << 17 | GenerateId,
    MimicCollider = 1 << 18,
    Reserved8 = 1 << 19,
    Reserved9 = 1 << 20,
    Reserved10 = 1 << 21,
    Reserved11 = 1 << 22,
    Reserved12 = 1 << 23,
    Reserved13 = 1 << 24,
    BlockHint = 1 << 25,
    CameraCorner = BlockHint | Type2,
    KiloTexture = 1 << 26,
    OptimizedWall = KiloTexture,
    CloneTileDef = 1 << 27,
    Annotation = 1 << 28,
    CameraTarget = 1 << 29,
}