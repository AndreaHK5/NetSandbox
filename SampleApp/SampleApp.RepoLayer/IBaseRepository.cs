using System.Collections.Generic;
using Norman.Data.Search;

namespace SampleApp.RepoLayer
{
    /// <summary>
    /// Repository Functions for Entity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Creates an entity T in the database
        /// </summary>
        /// <param name="Entity"></param>
        /// <returns></returns>
        bool Create(T Entity);

        /// <summary>
        /// Retrieves all entities T form database
        /// </summary>
        /// <returns>List T</returns>
        List<T> GetAll();

        /// <summary>
        /// Retrieves all entries that match the criteria specified
        /// </summary>
        /// <typeparam name="TSearch"></typeparam>
        /// <param name="searchCriteria"></param>
        /// <returns>List T</returns>
        List<T> FindAll<TSearch>(ExactCriteria<TSearch> searchCriteria);

        /// <summary>
        /// Updates all entries that match the Criteria (list of criteria can be passed in)
        /// </summary>
        /// <param name="Entity"></param>
        /// <param name="groupcriteria"></param>
        /// <returns>bool</returns>
        bool Update(T Entity, Criteria groupcriteria);

        /// <summary>
        /// Delete all entities that match Criteria (list of criteria can be passed in)
        /// </summary>
        /// <param name="Entity"></param>
        /// <param name="groupcriteria"></param>
        /// <returns>bool</returns>
        bool Delete(T Entity, Criteria groupcriteria);
    }
}
