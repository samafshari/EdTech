using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public class Folder : Asset
    {
        public string[] Children { get; set; } = []; // Ids for Boards, Things, ... in order
    }
}
