using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkoRestaurant.Data;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Services.Abstractions
{
    interface IDataService<TEntity> where TEntity : BaseEntity
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void Edit(TEntity entity);

        TEntity GetById(int id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        void SaveChanges();
    }
}
