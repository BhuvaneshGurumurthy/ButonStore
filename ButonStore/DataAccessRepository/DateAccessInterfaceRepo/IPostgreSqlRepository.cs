using System.Linq.Expressions;

namespace ButonStore.DataAccessRepository.DateAccessInterfaceRepo
{
    public interface IPostgreSqlRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
    }
}
