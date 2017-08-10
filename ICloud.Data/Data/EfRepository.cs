using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ICloud.Data.Data
{
    public partial class EfRepository<T> : IRepository<T> where T : BaseEntity
    {

        #region field
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public EfRepository(IDbContext context)
        {
            _context = context;
        }

        #endregion

        public IQueryable<T> GetTable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("插入参数不能为空！");

            this._entities.Add(entity);
            this._context.SaveChanges();
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("插入参数不能为空！");
            foreach (var entity in entities)
            {
                this._entities.Add(entity);
            }
            this._context.SaveChanges();
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("插入参数不能为空！");

            this._entities.Add(entity);
            this._context.SaveChanges();
        }

        public void Update(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("插入参数不能为空！");
            foreach (var entity in entities)
            {
                this._entities.Add(entity);
            }
            this._context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("插入参数不能为空！");

            this._entities.Add(entity);
            this._context.SaveChanges();
        }


        protected virtual IDbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }
}