using Requset.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Core.Contracts.Common
{
    public interface IBaseRepository<TEntity> where TEntity:BaseEntity,new ()
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        void Delete(int id);
        TEntity Add(TEntity entity);
    }
}
