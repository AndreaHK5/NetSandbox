using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Helpers
{
    /// <summary>
    /// Helper methods for controllers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IControllerHelper<T>
    {
        /// <summary>
        /// Generates a 200 response with the content of the list required.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>HttpResponseMessage</returns>
        HttpResponseMessage Ok(List<T> list);
    }
}
