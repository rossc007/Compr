using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Compr.EntityFramework.Repositories
{
    public abstract class ComprRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ComprDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ComprRepositoryBase(IDbContextProvider<ComprDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ComprRepositoryBase<TEntity> : ComprRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ComprRepositoryBase(IDbContextProvider<ComprDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
