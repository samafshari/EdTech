namespace Tyler.Models;

public class DataTypes
{
    public EnumDef[]? EnumDefs { get; set; }
    public DataStructure[]? DataStructures { get; set; }
}

[Flags]
public enum DataStructureExportType
{
    NotExported = 0,
    Struct = 1,
    Class = 2
}

public class EnumDef : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public EnumValue[]? Values { get; set; }
    public bool ExportCode { get; set; }
}

public class EnumValue : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class DataStructure : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public DataField[]? Fields { get; set; }
    public DataStructureExportType ExportType { get; set; }
    public string? Inherits { get; set; }
    public bool IsSerializable { get; set; }
}

public class DataField : IStringRecord
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string?[] DefaultValues { get; set; } = [];
    public bool IsPublic { get; set; }
    public bool IsGetter { get; set; }
    public bool IsSetter { get; set; }
    public bool IsList { get; set; }
    public bool IsStatic { get; set; }
}