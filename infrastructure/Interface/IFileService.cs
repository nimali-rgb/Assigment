

using infrastructure.Models;

namespace infrastructure.Interface;

public interface IFileService
{
    //behöver sök väg till filen, behöver innehåll där den böver sparas in då bool tells om de har sparts elr inte
    FileResult SaveContentToFile(string path, string content);
    FileResult GetContentFormFile(string path);
}
