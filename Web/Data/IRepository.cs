using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Add(TEntity entity);

        void Remove(TEntity entity);

        TEntity Get(Guid id);

        TEntity Find(Predicate<TEntity> search);
    }
}
