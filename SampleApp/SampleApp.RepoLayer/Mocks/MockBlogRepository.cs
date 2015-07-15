using System.Collections.Generic;
using SampleApp.Models;

namespace SampleApp.RepoLayer.Mocks
{
    public class MockBlogRepository : IBaseRepository<Blog>
    {
        public bool Create(Blog Entity)
        {
            return true;
        }

        public List<Blog> GetAll()
        {
            var bloglist = new List<Blog>();
            var blog = new Blog() {AuthorName = "Spina"};
            bloglist.Add(blog);
            return bloglist;
        }
    }
}
