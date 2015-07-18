using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp.Controllers;
using SampleApp.DTO;
using SampleApp.Models;

namespace SampleApp.API.Test {
    [TestClass]
    public class BlogControllerTest {
        
        [TestMethod]
        public void Put_Valid_Blog_Test() {
            // Arrange
            var controller = new BlogController();
            var blog = new BlogDto();
            blog.AuthorName = "somename";
            blog.Title = "SomeTitle";

            // Act
            var result = controller.Put(blog);

            // Assert
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
        }


        [TestMethod]
        public void Blog_Must_Validate_And_Return_Message () {
            // Arrange
            var controller = new BlogController();
            var blog = new BlogDto();

            // Act
            var result = controller.Put(blog);

            // Assert
            Assert.AreEqual(result.StatusCode, HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void Get_Blogs_Test() {
            //Arrange
            var controller = new BlogController();

            // Act
            var result = controller.Get();

            // Assert
            // TODO consider using MOQ instead?
            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
        }


    }
}
