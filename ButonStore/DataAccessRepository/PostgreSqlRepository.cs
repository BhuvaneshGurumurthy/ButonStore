using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ButonStore.Models;
using ButonStore.DataAccessRepository.DateAccessInterfaceRepo;

namespace ButonStore.DataAccessRepository
{
    public class PostgreSqlRepository<TEntity> : IPostgreSqlRepository<TEntity> where TEntity : class
    {
        public async Task Add(TEntity entity)
        {
            using(var db = new ButonStoreContext())
            {
                await db.AddAsync<TEntity>(entity);
                await db.SaveChangesAsync();
            }
        }
    }
}
