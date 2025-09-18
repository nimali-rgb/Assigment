

namespace infrastructure.Models;

public class FileResult
{
    public bool Success { get; set; }
    public string? Error { get; set; }
    public string? Content { get; set; }
    public bool Succeeded { get; set; }
}
