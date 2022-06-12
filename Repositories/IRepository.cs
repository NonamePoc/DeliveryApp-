using DeliveryApp.Entities;

namespace DeliveryApp.Repositories;

public interface IRepository<T> where T: class,IEntity
{
    T[] GetAll();

    T GetById(int id);

    void Update(T user);

    void Add(T user);

    void Delete(T user);
}