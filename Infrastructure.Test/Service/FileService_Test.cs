

using infrastructure.Interface;
using infrastructure.Models;
using Moq;

namespace Infrastructure.Test.Service;

public class FileService_Test
{
    [Fact]
    public void SaveContentToFile_ShouldReturnTrue_WhenContentSavedToFile()
    {
        //Arrange
        var fileSerivceMock = new Mock<IFileService>();
        var fileService = fileSerivceMock.Object;

        fileSerivceMock.Setup(fs=> fs.SaveContentToFile(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(FileResult);

        //Act
        var reslut = fileService.SaveContentToFile(",");

        //Assret
        Assert.False(reslut.Succeeded);
        Assert.Equal("Unable to save content.", reslut.Error);
    }
}