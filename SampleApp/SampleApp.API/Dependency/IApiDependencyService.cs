using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Dependency {
    /// <summary>
    /// Interface for dependency resolver for api project - Unity 
    /// </summary>
    public interface IApiDependencyService {
            /// <summary>
            /// Resolve a dependency to an implementation
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            T Resolve<T>();
    }
}
