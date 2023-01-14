using Microsoft.EntityFrameworkCore;
using WebUtilities.Model;

namespace WebUtilities.Interfaces;

public interface IRepository<T> where T : BaseObject
{
    public Task UpdateAsync(DbContext context, T entity);
    public Task DeleteAsync(DbContext context, T entity);
    public IQueryable<T> GetAll(DbContext context);
    public Task CreateAsync(DbContext context, T entity);
}