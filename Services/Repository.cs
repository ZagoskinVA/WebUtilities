using Microsoft.EntityFrameworkCore;
using WebUtilities.Interfaces;
using WebUtilities.Model;

namespace WebUtilities.Services;

public class Repository<T> : IRepository<T> where T : BaseObject
{
    public async Task CreateAsync(DbContext context, T entity)
    {
        entity.Id = Guid.NewGuid().ToString();
        context.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(DbContext context, T entity)
    {
        entity.IsDeleted = false;
        context.Update(entity);
        await context.SaveChangesAsync();
    }

    public IQueryable<T> GetAll(DbContext context)
    {
        return context.Set<T>().AsQueryable<T>();
    }

    public async Task UpdateAsync(DbContext context, T entity)
    {
        context.Update(entity);
        await context.SaveChangesAsync();
    }
}