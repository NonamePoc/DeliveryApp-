using DeliveryApp.EF;
using DeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Repositories;

public class RepositoryBase<T> : IRepository<T> where T : class, IEntity
{
    protected DeliveryContext Context { get; }

    public RepositoryBase(DeliveryContext context)
    {
        Context = context;
    }

    public virtual T[] GetAll()
    {
        return Context.Set<T>().ToArray();
    }

    public virtual T GetById(int id)
    {
        throw new InvalidOperationException();
    }

    public virtual void Update(T entity)
    {
        Context.Set<T>().Update(entity);
        Context.SaveChanges();
    }

    public virtual void Add(T entity)
    {
        Context.Set<T>().Add(entity);
        Context.SaveChanges();
    }

    public virtual void Delete(T entity)
    {
        Context.Set<T>().Remove(entity);
        Context.SaveChanges();
    }
}