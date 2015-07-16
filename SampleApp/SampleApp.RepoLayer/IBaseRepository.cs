using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norman.Data.Search;

namespace SampleApp.RepoLayer
{
    public interface IBaseRepository<T>
    {
        bool Create(T Entity);
        List<T> GetAll();
        List<T> FindAll<TSearch>(ExactCriteria<TSearch> searchCriteria);
        bool Update(T Entity, Criteria groupcriteria);
        bool Delete(T Entity, Criteria groupcriteria);
    }
}
