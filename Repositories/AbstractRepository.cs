using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public abstract class AbstractRepository<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        protected AppContext ApplicationContext { get; set; }
        
        public AbstractRepository()
        {
            ApplicationContext = new AppContext();
        }

        public virtual void Create(T entiry)
        {
            ApplicationContext.Set<T>().Add(entiry);
            ApplicationContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = new T() { Id = id };
            ApplicationContext.Set<T>().Attach(entity);
            ApplicationContext.Set<T>().Remove(entity);
            ApplicationContext.SaveChanges();
        }

        public virtual T GetModelById(int id)
        {
            return ApplicationContext.Set<T>().Where(t => t.Id == id).ToList().FirstOrDefault();
        }

        public virtual IEnumerable<T> GetModelCollections()
        {
            return ApplicationContext.Set<T>().ToList();
        }

        public virtual void Update(T entity)
        {
            //var sudent = GetModelById(entity.Id);
            //ApplicationContext.DbSet<T>().Attach(entity);
            var list = ApplicationContext.Set<T>().ToList();
            ApplicationContext.Entry(ApplicationContext.Set<T>().Find(entity.Id)).CurrentValues.SetValues(entity);

            //ApplicationContext.Entry(entity).State = EntityState.Modified;
            ApplicationContext.SaveChanges();

            return;
        }
    }
}
