using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using SampleApp.DTO.Mappers;

namespace SampleApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start() {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Mapper.Initialize(config =>
            {
                config.AddProfile(new BlogDtoMapper());
                config.AddProfile(new BlogMapper());
                config.AddProfile(new BlogPostDtoMapper());
                config.AddProfile(new BlogPostMapper());
            });
        }
    }
}
