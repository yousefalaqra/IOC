using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext{
    public DbSet<ItemEntity> ItemEntities { get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=OnlineShoping;Trusted_Connection=True;");
}