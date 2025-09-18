using infrastructure.Helpers_väl;

namespace infrastructure.Interface;

internal class IUniqGenerator : UniqGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}
