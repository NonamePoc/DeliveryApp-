namespace DeliveryApp.Entities;

public class User: IEntity
{
    public int Id { get; set; }
    
    public string Login { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public ICollection<Order> Orders { get; set; }

    public UserInformation UserInfo { get; set; }

    public User(string login, string password, string email)
    {
        Login = login;
        Password = password;
        Email = email;
    }
}