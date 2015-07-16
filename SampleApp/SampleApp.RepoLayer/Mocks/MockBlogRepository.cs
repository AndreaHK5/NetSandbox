using System.Collections.Generic;
using System.Dynamic;
using Norman.Data.Search;
using SampleApp.Models;

namespace SampleApp.RepoLayer.Mocks
{
    public class MockBlogRepository : IBaseRepository<Blog>
    {
        public bool Create(Blog Entity)
        {
            // TODO some validation needed here?
            return true;
        }

        public List<Blog> GetAll()
        {
            return GetMockList();
        }

        public List<Blog> FindAll<TSearch>(ExactCriteria<TSearch> searchCriteria)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Blog Entity, Criteria groupcriteria)
        {
            // TODO some validation needed here?
            return true;
        }

        public bool Delete(Blog Entity, Criteria groupcriteria)
        {
            // TODO some validation needed here?
            return true;
        }

        private List<Blog> GetMockList()
        {
            var bloglist = new List<Blog>();
            var blog = new Blog() { AuthorName = "Spina" };
            bloglist.Add(blog);
            return bloglist;
        } 
    }
}
