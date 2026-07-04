using Exam.Data.DbContest;
using Exam.Data.IRepositories;
using Exam.Domain.Configuration;
using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Exam.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{

    private AppDbContext dbContext;
    private readonly DbSet<TEntity> dbSet;
    public Repository()
    {
        this.dbContext = new AppDbContext();
        this.dbSet = dbContext.Set<TEntity>();
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        await dbSet.AddAsync(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> ModifyAsync(TEntity entity)
    {
        dbSet.Update(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var entity=await dbSet.FirstOrDefaultAsync(e=> e.Id == id);
        if (entity == null) return false;

        dbSet.Remove(entity);
        await dbContext.SaveChangesAsync();
        return true;
    }
    //IQueryable<TEntity>;
    public async Task<IEnumerable<TEntity>> SelectAllAsync()
    {
        return await dbSet.ToListAsync<TEntity>();
    }

    public async Task<TEntity> SelectByIdAsync(long id)
    {
        return await dbSet.FirstOrDefaultAsync(e=>e.Id== id);
    }
}
