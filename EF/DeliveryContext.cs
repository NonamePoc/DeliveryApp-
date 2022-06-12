using DeliveryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.EF;

public class DeliveryContext : DbContext
{
    private const string Connection = "Server=localhost;Database=DeliveryApp;Integrated Security=true;";

    public DbSet<User> Users { get; set; }

    public DbSet<Phone> Phones { get; set; }

    public DbSet<UserInformation> UsersInformations { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DeliveryContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(h => h.Id);

        modelBuilder.Entity<User>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<UserInformation>()
            .HasKey(h => h.UsersId);

        modelBuilder.Entity<UserInformation>()
            .Property(p => p.UsersId)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<UserInformation>()
            .HasOne(h => h.User)
            .WithOne(w => w.UserInfo)
            .HasForeignKey<UserInformation>(h => h.UsersId);


        modelBuilder.Entity<Phone>()
            .HasKey(h => h.Id);

        modelBuilder.Entity<Phone>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Phone>()
            .HasOne(h => h.Order)
            .WithMany(w => w.Phones)
            .HasForeignKey(f => f.OrderId);

        modelBuilder.Entity<Order>()
            .HasKey(h => h.Id);

        modelBuilder.Entity<Order>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Order>()
            .HasOne(h => h.User)
            .WithMany(w => w.Orders)
            .HasForeignKey(f => f.UserId);
    }
}