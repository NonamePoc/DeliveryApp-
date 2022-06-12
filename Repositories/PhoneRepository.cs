using DeliveryApp.EF;
using DeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Repositories;

public class PhoneRepository : RepositoryBase<Phone>
{
    public PhoneRepository(DeliveryContext context) : base(context)
    {
    }

    public override Phone[] GetAll()
    {
        return Context.Phones.ToArray();
    }
}