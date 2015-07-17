using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SampleApp.BusinessLayer.ModelServices;
using SampleApp.Models;
using SampleApp.RepoLayer;
using SampleApp.RepoLayer.Mocks;

namespace SampleApp.BusinessLayer.Dependency {
    /// <summary>
    /// Dependency container for Business Layer
    /// </summary>
    public class BusinessLayerDependencyService : IBusinessLayerDependencyService {
        private readonly IUnityContainer _dependencyContainer;

        /// <summary>
        /// Constructor
        /// </summary>
        public BusinessLayerDependencyService() {
            _dependencyContainer = new UnityContainer();
            RegisterDependencies();
        }

        public T Resolve<T>() { return _dependencyContainer.Resolve<T>(); }

        /// <summary>
        /// Register all dependencies
        /// </summary>
        private void RegisterDependencies() {
            // TODO implement app config for the test

            // Repositories
            switch (BusinessLayerConfig.Repository) {
                case AccessType.Persistance:
                    _dependencyContainer.RegisterType<IBaseRepository<Blog>, BaseRepository<Blog>>();
                    _dependencyContainer.RegisterType<IBaseRepository<BlogPost>, BaseRepository<BlogPost>>();
                    break;
                case AccessType.Mock:
                    _dependencyContainer.RegisterType<IBaseRepository<Blog>,MockBlogRepository>();
                    _dependencyContainer.RegisterType<IBaseRepository<BlogPost>, MockRepository<BlogPost>>();
                    break;
            }


            // Services
            _dependencyContainer.RegisterType<IBaseService<BlogPost>, BaseService<BlogPost>>();
            _dependencyContainer.RegisterType<IBaseService<Blog>, BaseService<Blog>>();
        }

    }
}
