using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using SampleApp.BusinessLayer;
using SampleApp.BusinessLayer.Mocks;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.Models;

namespace SampleApp.Dependency
{
    public class ApiDependencyService : IApiDependencyService {
            private readonly IUnityContainer _dependencyContainer;

            public ApiDependencyService() {
                _dependencyContainer = new UnityContainer();
                RegisterDependencies();
            }

            public T Resolve<T>() { return _dependencyContainer.Resolve<T>(); }

            private void RegisterDependencies() {
                switch (APIConfig.Repository)
                {
                    case BusinessLayerType.Production:
                        _dependencyContainer.RegisterType<IBaseService<BlogPost>, BaseService<BlogPost>>();
                        _dependencyContainer.RegisterType<IBaseService<Blog>, BaseService<Blog>>();
                        break;
                    case BusinessLayerType.Mock:
                        _dependencyContainer.RegisterType<IBaseService<BlogPost>, BaseService<BlogPost>>();
                        _dependencyContainer.RegisterType<IBaseService<Blog>, MockBlogService>();
                        break;
                }
            }

        }
}
