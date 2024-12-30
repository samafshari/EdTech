using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public class PresetPalette
{
    public string Name { get; set; } = "Untitled";
    public string? Author { get; set; }
    public string[] Colors { get; set; } = [];
}
