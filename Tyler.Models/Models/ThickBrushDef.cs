namespace Tyler.Models;

public class ThickBrushDef : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public float RoundnessRatio { get; set; } // 0=square 1=circle
    public float RotationRatio { get; set; } // 0=0, 1=360

    public static ThickBrushDef CreateDefault()
    {
        return new ThickBrushDef
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Default",
            Width = 2,
            Height = 2,
            RoundnessRatio = 1,
            RotationRatio = 0
        };
    }
}
