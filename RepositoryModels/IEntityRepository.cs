using System;
using System.Collections.Generic;

namespace RepositoryModels
{
    public interface IEntityRepository<T>
    {
        void Create(T student);
        T GetModelById(int id);
        IEnumerable<T> GetModelCollections();
        void Update(T student);
        void Delete(int id);
    }
}
