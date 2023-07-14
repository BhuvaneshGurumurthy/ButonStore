using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ButonStore.DbEntityClasses;
using ButonStore.DataAccessRepository.DateAccessInterfaceRepo;

namespace ButonStore.DataAccessRepository
{
    public class PostgreSqlRepository<TEntity> : IPostgreSqlRepository<TEntity> where TEntity : class
    {
        public async Task Add(TEntity entity)
        {
            using var db = new ButonStoreContext();
            await db.AddAsync<TEntity>(entity);
            await db.SaveChangesAsync();
        }

        public async Task<List<TEntity>> FetchEntity()
        {
            using var db = new ButonStoreContext();
            return await db.Set<TEntity>().ToListAsync<TEntity>();
        }

        public async Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> filter)
        {
            using var db = new ButonStoreContext();
            var data = await db.Set<TEntity>().Where(filter).ToListAsync();
            return data;
        }

        public async Task<int> FindCount(Expression<Func<TEntity, bool>> filter)
        {
            using var db = new ButonStoreContext();
            var data = await db.Set<TEntity>().CountAsync(filter);
            return data;
        }

        public async Task<int> Update(TEntity updatedData)
        {
            using var db = new ButonStoreContext();
            var data = db.Set<TEntity>().Update(updatedData);
            var enterpriseUpdated = await db.SaveChangesAsync();
            return enterpriseUpdated;
        }

        public async Task<int> UpdateAsBatch(List<TEntity> updatedData)
        {
            using var db = new ButonStoreContext();
            db.Set<TEntity>().UpdateRange(updatedData);
            var enterpriseUpdated = await db.SaveChangesAsync();
            return enterpriseUpdated;
        }
    }
}
