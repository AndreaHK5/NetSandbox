using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.RepoLayer
{
    public interface IBaseRepository<T>
    {
        bool Create(T Entity);
        List<T> GetAll();
        // TODO add the other CRUD operations
    }
}
