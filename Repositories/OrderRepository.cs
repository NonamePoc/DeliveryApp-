using DeliveryApp.EF;
using DeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Repositories;

public class OrderRepository : RepositoryBase<Order>
{
    public OrderRepository(DeliveryContext context) : base(context)
    {
    }

    public override Order[] GetAll()
    {
        return Context.Orders
            .Include(i => i.Phones)
            .Include(f => f.User)
            .ToArray();
    }
}