using infrastructure.Helpers_väl;

namespace Infrastructure.Test.Helper;

public class UniqIdGenerator_Test
    //try parse
{
    [Fact]
    public void Generate_ShouldReturnGuidAsString_WhenSuccessful(UniqGenerator uniqGenerator)
    {
        //act
        string reslut = UniqGenerator.Generate();


        //Assert
        Assert.True(Guid.TryParse(reslut, out Guid id));
        Assert. IsType<Guid>(id);

    }
}
