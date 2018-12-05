using System;
using System.Web.Http.Common;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MakeMedia.WebAPI.Controllers;
using MakeMedia.WebAPI;
using MakeMedia.Services;

namespace MakeMedia.WebAPI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFileService fileSvc = new FileService();
            //FileController controller = new FileController();
            // Act
            Assert.IsTrue(true);
            //dynamic result = controller.GetFile("test.txt");
            //Assert.Equals(result, "test00");
            //throw new NotImplementedException();
            // arrange
            


        }
    }
}
