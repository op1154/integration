using ErpOrdersDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpOrdersDemo.Data;

public class ErpDbContext : DbContext
{
    public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(o => o.CustomerName).IsRequired().HasMaxLength(100);
            entity.Property(o => o.ProductName).IsRequired().HasMaxLength(100);
            entity.Property(o => o.Total).HasColumnType("decimal(18,2)");
            entity.Property(o => o.Status).HasMaxLength(30);
        });
    }
}
