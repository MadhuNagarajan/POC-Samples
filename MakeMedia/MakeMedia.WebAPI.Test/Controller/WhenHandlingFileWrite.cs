using Moq;
using NUnit.Framework;
using MakeMedia.Services;
using MakeMedia.WebAPI.Controllers;
using MakeMedia.WebAPI.DataContracts;

namespace MakeMedia.WebAPI.Test.Controller
{
    public class WhenHandlingFileWrite
    {
        protected const string FileTestData = "testfilecontent";
        [Test]
        protected void Give_A_Content_Write_To_File()
        {
            //throw new NotImplementedException();
            //Arrange
            Mock<IFileService> MockfileSvc = new Mock<IFileService>();
            bool returnFlag = true;
            MockfileSvc.Setup(x => x.SaveFile(It.IsAny<string>(), It.IsAny<string>())).Returns(returnFlag);
            WriteFileDataContract fileDataContract = new WriteFileDataContract { Filename = "test.txt", FileContent = "hello world" };
            FileController fileController = new FileController(MockfileSvc.Object);
            //Act
            var Result = fileController.WriteFile(fileDataContract);
            //Assert
            //Assert.AreEqual(Result, returnFlag);
        }

        [Test]
        protected void Given_A_Invalid_Request()
        {
            
        }
    }
}
