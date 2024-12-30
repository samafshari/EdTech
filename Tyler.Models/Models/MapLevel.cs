namespace Tyler.Models;

public class MapLevel : Thing
{
    public string? LevelId { get; set; }
    public bool IsTrimmed { get; set; }
    public float Scale { get; set; } = 1;
}
