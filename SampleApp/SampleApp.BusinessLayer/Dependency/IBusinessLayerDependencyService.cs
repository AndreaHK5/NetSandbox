using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.BusinessLayer.Dependency {
    /// <summary>
    /// Dependency container for Business Layer
    /// </summary>
    public interface IBusinessLayerDependencyService {
        T Resolve<T>();
    }
}
