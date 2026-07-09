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

    public async Task<bool> RemoveAsync(Guid id)
    {
        var entity=await dbSet.FirstOrDefaultAsync(e=> e.Id == id);
        if (entity == null) return false;

        dbSet.Remove(entity);
        await dbContext.SaveChangesAsync();
        return true;
    }
    //IQueryable<TEntity>;
    public IQueryable<TEntity> RetrieveAll()
    {
        return dbSet;
    }

    public async Task<TEntity> SelectByIdAsync(Guid id)
    {
        return await dbSet.FirstOrDefaultAsync(e=>e.Id== id);
    }
}
