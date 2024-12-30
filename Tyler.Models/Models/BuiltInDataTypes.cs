using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public static class BuiltInDataTypes
{
    public static string Float { get; } = "float";
    public static string Int { get; } = "int";
    public static string String { get; } = "string";
    public static string Bool { get; } = "bool";

    public static string[] Items { get; } = [String, Bool, Int, Float];
}
