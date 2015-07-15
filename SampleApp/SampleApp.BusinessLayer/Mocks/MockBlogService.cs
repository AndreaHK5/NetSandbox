using System.Collections.Generic;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.Models;

namespace SampleApp.BusinessLayer.Mocks {
    public class MockBlogService : IBaseService<Blog> {
        public bool Create(Blog Entity) {
            return true;
        }

        public List<Blog> GetAll(){
            var bloglist = new List<Blog>();
            var blog = new Blog() { AuthorName = "Spina" };
            bloglist.Add(blog);
            return bloglist;
        }
    }
}
