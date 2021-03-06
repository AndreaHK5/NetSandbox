﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.BusinessLayer.Validation;
using SampleApp.Dependency;
using SampleApp.DTO;
using SampleApp.Helpers;

namespace SampleApp.Controllers
{
    /// <summary>
    /// Blog Controller
    /// </summary>
    [RoutePrefix("api/blog")]
    public class BlogController : ApiController {
        private readonly IModelService<BlogDto> _blogService;

        /// <summary>
        /// Constructor for injection
        /// </summary>
        public BlogController() {
            var _dependencyService = new ApiDependencyService();
            _blogService = _dependencyService.Resolve<IModelService<BlogDto>>();
        }

        /// <summary>
        /// Put end point with validation
        /// </summary>
        /// <param name="blog"></param>
        /// <returns>http status</returns>
        /// <remarks>PUT: api/blog/v1</remarks>
        [Route("v1/")]
        [HttpPut]
        public HttpResponseMessage Put(BlogDto blog)
        {
            var validationService = new BlogValidation();
            var results = validationService.Validate(blog);
            if (!results.IsValid)
            {
                return ValidationHelper.FailedValidationMessage(results);
            }
            _blogService.Create(blog);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// get end point
        /// </summary>
        /// <returns>List of blogs</returns>
        /// <remarks>GET: api/blog/v1</remarks>
        [Route("v1/")]
        [HttpGet]
        public HttpResponseMessage Get() {
            var results = _blogService.GetAll();

            var helper = new BaseControllerHelper<BlogDto>();

            return helper.Ok(results);
        }

    }
}
