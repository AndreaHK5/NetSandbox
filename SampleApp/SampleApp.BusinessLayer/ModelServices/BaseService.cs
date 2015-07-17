using System;
using System.Collections.Generic;
using Norman.Data.Persistence;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.RepoLayer;

namespace SampleApp.BusinessLayer.ModelServices
{
    /// <summary>
    /// Generics implementation of service for a model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseService<T> : IBaseService<T> where T : BaseDataObject {

        private readonly IBusinessLayerDependencyService _dependencyService;
        private IBaseRepository<T> _repository;

        /// <summary>
        /// Constructor.
        /// </summary>
        public BaseService() {
            _dependencyService = new BusinessLayerDependencyService();
            _repository = _dependencyService.Resolve<IBaseRepository<T>>();
        }

        /// <summary>
        /// Create T in repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        public bool Create(T entity) {

            // TODO implement logic if required
            return _repository.Create(entity);
        }

        /// <summary>
        /// Get all T in repository
        /// </summary>
        /// <returns>List of T</returns>
        public List<T> GetAll() {
           return _repository.GetAll();
        }
    }
}
