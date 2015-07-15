using System.Collections.Generic;
using System.Web.Http;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.Dependency;
using SampleApp.Models;

namespace SampleApp.Controllers
{
    [RoutePrefix("api/blog")]
    public class BlogController : ApiController {
        private readonly IApiDependencyService _dependencyService;
        private readonly IBaseService<Blog> _blogService;

        public BlogController() {
            _dependencyService = new ApiDependencyService();
            _blogService = _dependencyService.Resolve<IBaseService<Blog>>();
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult Put(Blog blog) {
            _blogService.Create(blog);
            return Ok();
        }

        [Route("")]
        [HttpGet]
        public List<Blog> Get()
        {
            return _blogService.GetAll();
        }

    }
}
