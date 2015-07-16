using System.Collections.Generic;
using Norman.Data.Persistence;
using Norman.Data.Search;

namespace SampleApp.RepoLayer.Mocks
{
    public abstract class MockRepository<T> : IBaseRepository<T> where T : BaseDataObject, new()
    {
        
        // TODO remove this in case the mocks do not have a generalized behavior and just rely on the actual implementations
        public bool Create(T Entity) {
            return true;
        }

        public abstract List<T> GetAll();

        public abstract List<T> FindAll<TSearch>(ExactCriteria<TSearch> searchCriteria);

        public abstract bool Update(T Entity, Criteria groupcriteria) ;

        public abstract bool Delete(T Entity, Criteria groupcriteria);
    }
}
