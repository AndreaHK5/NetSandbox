using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norman.Data.Persistence;

namespace SampleApp.RepoLayer
{
    public class MockRepository<T> : IBaseRepository<T> where T : BaseDataObject, new()
    {
        private readonly ReflectiveFactory Factory = ReflectiveFactory.Instance;
        public bool Create(T Entity)
        {
            return true;
        }

        public List<T> GetAll()
        {
            return new List<T>();
        }
    }
}
