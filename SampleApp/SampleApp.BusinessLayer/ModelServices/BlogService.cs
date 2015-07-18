using System.Collections.Generic;
using AutoMapper;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.DTO;
using SampleApp.Models;
using SampleApp.RepoLayer;

namespace SampleApp.BusinessLayer.ModelServices {
    public class BlogService : IModelService<BlogDto> {
        private IBaseRepository<Blog> _repository;

        /// <summary>
        /// Constructor.
        /// </summary>
        public BlogService() {
            var dependencyService = new BusinessLayerDependencyService();
            _repository = dependencyService.Resolve<IBaseRepository<Blog>>();
        }

        /// <summary>
        /// Create T in repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        public bool Create(BlogDto entity) {

            // TODO implement logic if required
            return _repository.Create(Mapper.Map<Blog>(entity));
        }

        /// <summary>
        /// Get all T in repository
        /// </summary>
        /// <returns>List of T</returns>
        public List<BlogDto> GetAll()
        {
            var result = new List<BlogDto>();
           _repository.GetAll().ForEach(b => result.Add(Mapper.Map<BlogDto>(b)));
            return result;
        }
    }
}
