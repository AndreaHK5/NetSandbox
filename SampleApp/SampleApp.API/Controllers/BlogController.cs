using System.Collections.Generic;
using System.Web.Http;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.Dependency;
using SampleApp.Models;

namespace SampleApp.Controllers
{
    /// <summary>
    /// Blog Controller
    /// </summary>
    [RoutePrefix("api/blog")]
    public class BlogController : ApiController {
        private readonly IBaseService<Blog> _blogService;

        /// <summary>
        /// Constructor for injection
        /// </summary>
        public BlogController() {
            var _dependencyService = new ApiDependencyService();
            _blogService = _dependencyService.Resolve<IBaseService<Blog>>();
        }

        /// <summary>
        /// Put end point
        /// </summary>
        /// <param name="blog"></param>
        /// <returns>http status</returns>
        /// <remarks>PUT: api/blog/v1</remarks>
        [Route("v1/")]
        [HttpPut]
        public IHttpActionResult Put(Blog blog) {
            _blogService.Create(blog);
            return Ok();
        }

        /// <summary>
        /// get end point
        /// </summary>
        /// <returns>List of blogs</returns>
        /// <remarks>GET: api/blog/v1</remarks>
        [Route("v1/")]
        [HttpGet]
        public List<Blog> Get()
        {
            return _blogService.GetAll();
        }

    }
}
