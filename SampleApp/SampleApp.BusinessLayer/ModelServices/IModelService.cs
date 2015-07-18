using System.Collections.Generic;

namespace SampleApp.BusinessLayer.ModelServices
{
    /// <summary>
    /// Service interface for a persisted model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IModelService<T> {
        // TODO implement all other CRUD methods?
        bool Create(T Entity);
        List<T> GetAll();


    }
}
