namespace DeliveryApp.Entities;

public class Order : IEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }

    public DateTime Date { get; set; }

    public string Comment { get; set; }

    public ICollection<Phone> Phones { get; set; }
    
}