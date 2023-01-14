using Microsoft.EntityFrameworkCore;
using WebUtilities.Interfaces;
using WebUtilities.Model;

namespace WebUtilities.Services;

public class CrudService<T> : ICrudService<T> where T : BaseObject
{
    private readonly IRepository<T> _repository;

    public CrudService(IRepository<T> repository)
    {
        if (repository == null) throw new ArgumentNullException(nameof(repository));
        _repository = repository;
    }

    public virtual async Task CreateAsync(DbContext context, T entity)
    {
        await _repository.CreateAsync(context, entity);
    }

    public virtual async Task UpdateAsync(DbContext context, T entity)
    {
        await _repository.UpdateAsync(context, entity);
    }

    public virtual async Task DeleteAsync(DbContext context, T entity)
    {
        await _repository.DeleteAsync(context, entity);
    }

    public virtual IQueryable<T> GetAll(DbContext context)
    {
        return _repository.GetAll(context);
    }
}