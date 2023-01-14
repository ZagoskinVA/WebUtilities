using Microsoft.EntityFrameworkCore;
using WebUtilities.Model;

namespace WebUtilities.Interfaces;

public interface ICrudService<T> where T : BaseObject
{
    Task CreateAsync(DbContext context, T entity);

    Task UpdateAsync(DbContext context, T entity);

    Task DeleteAsync(DbContext context, T entity);

    IQueryable<T> GetAll(DbContext context);
}