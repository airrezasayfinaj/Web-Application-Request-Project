using Requset.Core.Contracts.Common;
using Requset.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Infrastructures.AccessData.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly RequsetContext requsetContext;
        public BaseRepository(RequsetContext requsetContext)
        {
            this.requsetContext = requsetContext;
        }
        public TEntity Add(TEntity entity)
        {
            requsetContext.Set<TEntity>().Add(entity);
            requsetContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                id = id
            };
            requsetContext.Remove(entity);
            requsetContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return requsetContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return requsetContext.Set<TEntity>().AsQueryable();
        }
    }
}
