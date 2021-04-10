using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using EkoRestaurant.Data.Abstractions;
using EkoRestaurant.Services.Abstractions;

namespace EkoRestaurant.Services.Abstractions
{
    public abstract class BaseDataService<TEntity> : IDataService<TEntity> 
        where TEntity : BaseEntity
    {

        protected readonly ApplicationDbContext _dbContext;

        protected BaseDataService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Create(TEntity entity)
        {
            var addedEntityEntry = _dbContext.Set<TEntity>().Add(entity);
            return addedEntityEntry.Entity;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Delete(int id)
        {
            var entityToDelete = _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
            if (entityToDelete != null)
            {
                _dbContext.Set<TEntity>().Remove(entityToDelete);
            }
        }

        public TEntity Edit(TEntity entity)
        {
            var editedEntity = _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);
            editedEntity = entity;
            return editedEntity;
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<TEntity> Filter()
        {
            return _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
