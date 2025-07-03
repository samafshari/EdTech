namespace Tyler.Models;

public interface IStringRecord
{
    public string? Id { get; }
}

public abstract class Record : IStringRecord, IDiffable
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}

public class Asset : Record
{
    public int Rank { get; set; }
    public uint Handle { get; set; }
    public string? Ref { get; set; }
}