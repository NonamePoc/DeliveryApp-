namespace DeliveryApp.Entities;

public class UserInformation: IEntity
{
    public int Id { get; set; }
    public int UsersId { get; set; }

    public string Name { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public User User  { get; set; }
}