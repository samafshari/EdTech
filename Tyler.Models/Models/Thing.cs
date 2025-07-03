namespace Tyler.Models
{
    public abstract class Thing : Record
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string? ParentId { get; set; }
        public string? Name { get; set; }
        public bool IsVisible { get; set; } = true;
        public double ParallaxX { get; set; } = 1;
        public double ParallaxY { get; set; } = 1;
    }
}
