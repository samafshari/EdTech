namespace Tyler.Models;

public class BitmapEffectsPreset : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public BitmapEffect[] Items { get; set; } = [];

    public override string? ToString()
    {
        return Name;
    }
}
