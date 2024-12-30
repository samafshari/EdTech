namespace Tyler.Models;

public class RuleBrush : Asset
{
    public BrushRule[]? Rules { get; set; }
    public RuleBrushType Type { get; set; }
    public string? ProxyId { get; set; }
    public string?[]? FriendBrushIds { get; set; }
}
