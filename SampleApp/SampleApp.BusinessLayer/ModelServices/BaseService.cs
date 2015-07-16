using System;
using System.Collections.Generic;
using Norman.Data.Persistence;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.RepoLayer;

namespace SampleApp.BusinessLayer.ModelServices
{
    public class BaseService<T> : IBaseService<T> where T : BaseDataObject {

        private readonly IBusinessLayerDependencyService _dependencyService;
        private IBaseRepository<T> _repository;

        public BaseService() {
            _dependencyService = new BusinessLayerDependencyService();
            _repository = _dependencyService.Resolve<IBaseRepository<T>>();
        }

        public bool Create(T entity) {
            return _repository.Create(entity);
        }

        public List<T> GetAll() {
           return _repository.GetAll();
        }
    }
}
