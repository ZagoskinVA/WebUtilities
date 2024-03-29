﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebUtilities.Interfaces;
using WebUtilities.Model;

namespace WebUtilities.Services;

public class CrudService<T> : ICrudService<T> where T : BaseObject
{
    private readonly IRepository<T> _repository;
    private readonly ILogger _logger;

    public CrudService(IRepository<T> repository, ILogger<CrudService<T>> logger)
    {
        if (repository == null) throw new ArgumentNullException(nameof(repository));
        _repository = repository;
        _logger = logger;
    }

    public virtual async Task CreateAsync(DbContext context, T entity)
    {
        _logger.LogInformation($"Start creating entity: {typeof(T).Name} with ID {entity.Id}");
        await _repository.CreateAsync(context, entity);
        _logger.LogInformation($"Successfully created entity: {typeof(T).Name} with ID {entity.Id}");
    }

    public virtual async Task UpdateAsync(DbContext context, T entity)
    {
        _logger.LogInformation($"Start updating entity: {typeof(T).Name} with ID {entity.Id}");
        await _repository.UpdateAsync(context, entity);
        _logger.LogInformation($"Successfully updated entity: {typeof(T).Name} with ID {entity.Id}");
    }

    public virtual async Task DeleteAsync(DbContext context, T entity)
    {
        _logger.LogInformation($"Start deleting entity: {typeof(T).Name} with ID {entity.Id}");
        await _repository.DeleteAsync(context, entity);
        _logger.LogInformation($"Start deleted entity: {typeof(T).Name} with ID {entity.Id}");
    }

    public virtual IQueryable<T> GetAll(DbContext context)
    {
        _logger.LogInformation($"Get entities: {typeof(T).Name}");
        return _repository.GetAll(context);
    }
}