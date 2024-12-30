using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models;

public class LibrarySaveMetaData
{
    public string? FileId { get; set; }
    public string? SnapshotId { get; set; }
    public string? Name { get; set; }
    public string? Path { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public string? ThumbnailPath { get; set; }
    public bool IsAutoSave { get; set; }
}
