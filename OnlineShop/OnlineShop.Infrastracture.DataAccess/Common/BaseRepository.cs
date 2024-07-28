using OnlineShop.Domain.Contracts.Common;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly OnlineShopContext dbcontext;

        protected BaseRepository(OnlineShopContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public TEntity Add(TEntity entity)
        {
            dbcontext.Set<TEntity>().Add(entity);
            dbcontext.SaveChanges();
            return entity;


        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                Id = id
            };
            dbcontext.Remove(entity);
            dbcontext.SaveChanges();


        }

        public TEntity Get(int id)
        {
            return dbcontext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbcontext.Set<TEntity>().AsQueryable();
        }
    }
}
