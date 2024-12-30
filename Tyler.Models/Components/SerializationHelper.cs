using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Components
{
    public static class SerializationHelper
    {
        public static async Task UnzipAsync(Stream fileStream, string destination)
        {
            Directory.CreateDirectory(destination);
            await using var stream = new MemoryStream();
            await fileStream.CopyToAsync(stream);
            await Task.Run(() =>
            {
                using (var zip = new ZipArchive(stream, ZipArchiveMode.Read, false))
                {
                    foreach (var entry in zip.Entries)
                    {
                        var path = Path.Combine(destination, entry.FullName);
                        Console.WriteLine($"Processing zip entry: {path}");
                        try
                        {
                            var directory = Path.GetDirectoryName(path);
                            if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
                                Directory.CreateDirectory(directory);
                            if (File.Exists(path)) File.Delete(path);
                            using (var archiveStream = entry.Open())
                            {
                                using (var fileStream = File.Create(path))
                                    archiveStream.CopyTo(fileStream);
                            }
                            Console.WriteLine($"Extracted zip entry: {path}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
            });
        }
    }
}
