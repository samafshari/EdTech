using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public class Map : Record
{
    public string? Name { get; set; }
    public MapLevel[] Levels { get; set; } = [];
    public string[] Children { get; set; } = []; // Ids for Levels, Things, ... in order
}
