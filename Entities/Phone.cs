namespace DeliveryApp.Entities;

public class Phone: IEntity
{
    public int Id { get; set; }

    public Order Order { get; set; }

    public int OrderId { get; set; }

    public string Model { get; set; }

    public int Ram { get; set; }

    public int NumbersSim { get; set; }
}