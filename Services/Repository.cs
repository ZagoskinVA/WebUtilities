using Microsoft.EntityFrameworkCore;
using WebUtilities.Interfaces;
using WebUtilities.Model;

namespace WebUtilities.Services;

public class Repository<T> : IRepository<T> where T : BaseObject
{
    public async Task CreateAsync(DbContext context, T entity)
    {
        if(string.IsNullOrEmpty(entity.Id))
            entity.Id = Guid.NewGuid().ToString();

        context.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(DbContext context, T entity)
    {
        entity.IsDeleted = false;
        
        await UpdateAsync(context, entity);
    }

    public IQueryable<T> GetAll(DbContext context)
    {
        return context.Set<T>().AsQueryable<T>().AsNoTracking();
    }

    public async Task UpdateAsync(DbContext context, T entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }
}