using System.Collections.Generic;
using System.Data.Entity;

namespace ICloud.Data
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();

        IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters)
           where TEntity : BaseEntity, new();

        IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters);
    }
}