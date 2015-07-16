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
            var controller = new BlogController();

            var blog = new Blog();
            IHttpActionResult result = controller.Put(blog);

            Assert.IsInstanceOfType(result, typeof(OkResult));
        }
        [TestMethod]
        public void GetTest() {
            var controller = new BlogController();

            var blog = new Blog();
            var result = controller.Get();

            Assert.AreEqual(result.Count, 1);
        }
    }
}
