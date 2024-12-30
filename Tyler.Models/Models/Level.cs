using Newtonsoft.Json;

namespace Tyler.Models
{
    public class Level : Record, IVarsAndComponentsModel
    {
        public string? Name { get; set; }
        public Board[] Boards { get; set; } = [];
        public Quad[] Quads { get; set; } = [];
        public string[] Children { get; set; } = []; // Ids for Boards, Things, ... in order
        public string[]? Extern { get; set; }
        public BoardStamp[]? PreviewStamps { get; set; }
        public Variable[]? Variables { get; set; }
        public DataComponent[]? DataComponents { get; set; }
        [JsonIgnore] public long DataContainerId { get; set; }
    }
}
