using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.BusinessLayer.ModelServices
{
    public interface IBaseService<T> {
        bool Create(T Entity);
        List<T> GetAll();
    }
}
