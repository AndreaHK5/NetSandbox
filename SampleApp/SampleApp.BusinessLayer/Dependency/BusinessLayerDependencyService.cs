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
    public class BusinessLayerDependencyService : IBusinessLayerDependencyService {
        private readonly IUnityContainer _dependencyContainer;

        public BusinessLayerDependencyService() {
            _dependencyContainer = new UnityContainer();
            RegisterDependencies();
        }

        public T Resolve<T>() { return _dependencyContainer.Resolve<T>(); }

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
