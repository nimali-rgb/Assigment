using infrastructure.Helpers_väl;

namespace infrastructure.Interface;

public class IUniqIdGenerator : UniqGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}
