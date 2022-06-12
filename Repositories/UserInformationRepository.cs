using DeliveryApp.EF;
using DeliveryApp.Entities;

namespace DeliveryApp.Repositories;

public class UserInformationRepository : RepositoryBase<UserInformation>
{
    public UserInformationRepository(DeliveryContext context) : base(context)
    {
        
    }
    
    public override UserInformation[] GetAll()
    {
        return Context.UsersInformations.ToArray();
    }
}