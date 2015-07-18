using System.Collections.Generic;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.DTO;
using SampleApp.Models;

namespace SampleApp.BusinessLayer.Mocks {
    /// <summary>
    /// Mock implementation of Blog Service
    /// </summary>
    public class MockBlogService : IModelService<BlogDto> {
        public bool Create(BlogDto Entity) {
            return true;
        }

        public List<BlogDto> GetAll(){
            var bloglist = new List<BlogDto>();
            var blog = new BlogDto() { AuthorName = "Spina" };
            bloglist.Add(blog);
            return bloglist;
        }
    }
}
