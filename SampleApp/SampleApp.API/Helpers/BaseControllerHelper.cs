using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SampleApp.Helpers
{
    public class BaseControllerHelper<T> : IControllerHelper<T>
    {
        public HttpResponseMessage Ok(List<T> list)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(list));
            return response;
        }
    }
}
