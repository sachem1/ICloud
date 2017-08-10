using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace ICloud.Demo
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(string nameOrConnectionString) : base("name=SqlserverContext")
        {
        }

        public SqlServerContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public SqlServerContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public SqlServerContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public SqlServerContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected SqlServerContext()
        {
        }

        protected SqlServerContext(DbCompiledModel model) : base(model)
        {
        }

        public virtual  IDbSet<username>
    }
}