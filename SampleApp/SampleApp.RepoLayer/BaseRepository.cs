using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Norman.Data.Persistence;

namespace SampleApp.RepoLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseDataObject, new() 
    {
        private readonly ReflectiveFactory Factory = ReflectiveFactory.Instance;
        public bool Create(T Entity){
            return Factory.SaveOrUpdate(Entity, new Guid());
        }

        public List<T> GetAll() {
            return new List<T>(Factory.LoadAll<T>());
        }
    }
}
