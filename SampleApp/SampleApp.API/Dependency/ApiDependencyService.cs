using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using SampleApp.BusinessLayer;
using SampleApp.BusinessLayer.Mocks;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.DTO;

namespace SampleApp.Dependency
{
    /// <summary>
    /// Dependency resolver for api project - Unity 
    /// </summary>
    public class ApiDependencyService : IApiDependencyService {
            private readonly IUnityContainer _dependencyContainer;
            
            /// <summary>
            /// Constructor
            /// </summary>
            public ApiDependencyService() {
                _dependencyContainer = new UnityContainer();
                RegisterDependencies();
            }

            
            public T Resolve<T>() { return _dependencyContainer.Resolve<T>(); }
            
            /// <summary>
            /// Resolve dependencies
            /// </summary>
            private void RegisterDependencies() {
                switch (APIConfig.Repository)
                {
                    case BusinessLayerType.Production:
                        _dependencyContainer.RegisterType<IModelService<BlogPostDto>, BlogPostDtoService>();
                        _dependencyContainer.RegisterType<IModelService<BlogDto>, BlogService>();
                        break;
                    case BusinessLayerType.Mock:
                        _dependencyContainer.RegisterType<IModelService<BlogPostDto>, BlogPostDtoService>();
                        _dependencyContainer.RegisterType<IModelService<BlogDto>, MockBlogService>();
                        break;
                }
            }

        }
}
