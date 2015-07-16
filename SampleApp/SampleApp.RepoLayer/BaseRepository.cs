using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norman.Data.Persistence;
using Norman.Data.Search;

namespace SampleApp.RepoLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseDataObject, new() 
    {
        private readonly ReflectiveFactory Factory = ReflectiveFactory.Instance;

        public bool Create(T Entity)
        {
            return Factory.SaveOrUpdate(Entity, new Guid());
        }

        public List<T> GetAll()
        {
            return new List<T>(Factory.LoadAll<T>());
        }

        public List<T> FindAll<TSearch>(ExactCriteria<TSearch> searchCriteria)
        {
            return Factory.Search<T>(searchCriteria).ToList();
        }

        public bool Update(T Entity, Criteria groupcriteria)
        {
            var items = Factory.Search<T>(groupcriteria).ToList();
            if (items.Count != 1)
            {
                return false;
            }
            return Factory.SaveOrUpdate(Entity, items.First().Id);
        }

        public bool Delete(T Entity, Criteria groupcriteria)
        {
            var items = Factory.Search<T>(groupcriteria).ToList();
            if (items.Count != 1)
            {
                return false;
            }
            return Factory.DeletePermanently(items.First().Id);
        }
    }
}
