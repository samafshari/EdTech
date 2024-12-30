using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public class Pattern : Asset
{
    public string? Name { get; set; }
    public Tile[] Tiles { get; set; } = [];
    public int Width { get; set; }
    public int Height { get; set; }
}

public class PatternState : AssetState
{
    public string? ThumbnailPath { get; set; }
}