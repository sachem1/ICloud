﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloud.Data.Data
{
    public partial interface IRepository<T> where T:BaseEntity
    {
        T GetById(int id);
       
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);

        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IQueryable<T> GetTable { get; }
        IQueryable<T> TableNoTracking { get; }

        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
    }
}
