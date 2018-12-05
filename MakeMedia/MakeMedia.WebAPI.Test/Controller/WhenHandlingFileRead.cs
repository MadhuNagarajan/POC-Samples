using System;
using Moq;
using NUnit.Framework;
using MakeMedia.Repository;
using MakeMedia.WebAPI.Controllers;
using MakeMedia.Services;
using MakeMedia.WebAPI.DataContracts;
using System.Web.Http;

namespace MakeMedia.WebAPI.Test.Controller
{
    public class WhenHandlingFileRead
    {
        [Test]
        protected void Give_A_FileName_Read_Conent()
        {
            //Arrange
            //throw new NotImplementedException();
            Mock<IRepository> repository = new Mock<IRepository>();
            Mock<IFileService> MockFileSvc = new Mock<IFileService>();
            string content = string.Empty;
            MockFileSvc.Setup(x => x.ReadFile(It.IsAny<string>())).Returns(content);
            FileController fileController = new FileController(MockFileSvc.Object);

            //Act
            var Result = fileController.GetFile("test.txt");
            //Assert
            Assert.AreEqual(Result, "Hello World");
        }

        [Test]
        protected void Given_A_Invalid_Request()
        {

        }

        [Test]
        protected void Given_A_Invalid_FileName_Throwns_Not_Found_Error()
        {

        }
    }
}
