using System.Collections.Generic;
using AutoMapper;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SampleApp.BusinessLayer.Dependency;
using SampleApp.DTO;
using SampleApp.Models;
using SampleApp.RepoLayer;

namespace SampleApp.BusinessLayer.ModelServices
{
    public class BlogPostDtoService : IModelService<BlogPostDto>
    {
        private IBaseRepository<BlogPost> _repository;

        /// <summary>
        /// Constructor.
        /// </summary>
        public BlogPostDtoService()
        {
            var dependencyService = new BusinessLayerDependencyService();
            _repository = dependencyService.Resolve<IBaseRepository<BlogPost>>();
        }

        /// <summary>
        /// Create T in repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        public bool Create(BlogPostDto entity)
        {
            // TODO implement custom logic if required
            return _repository.Create(Mapper.Map<BlogPost>(entity));
        }

        /// <summary>
        /// Get all T in repository
        /// </summary>
        /// <returns>List of T</returns>
        public List<BlogPostDto> GetAll()
        {
            var result = new List<BlogPostDto>();
            _repository.GetAll().ForEach(b => result.Add(Mapper.Map<BlogPostDto>(b)));
            return result;
        }
    }
}
