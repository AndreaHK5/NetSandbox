using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp.Controllers;
using SampleApp.Models;

namespace SampleApp.API.Test {
    [TestClass]
    public class BlogControllerTest {
        
        [TestMethod]
        public void PutTest() {
            // Arrange
            var controller = new BlogController();
            var blog = new Blog();

            // Act
            IHttpActionResult result = controller.Put(blog);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }

        [TestMethod]
        public void GetTest() {
            //Arrange
            var controller = new BlogController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual(result.Count, 1);
        }
    }
}
