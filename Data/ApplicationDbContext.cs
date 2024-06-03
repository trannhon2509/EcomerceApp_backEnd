using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using EcomerceApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcomerceApp.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }

    public DbSet<EcomerceApp.Models.Product> Products { get; set; }
    public DbSet<EcomerceApp.Models.Category> Categories { get; set; }
    public DbSet<EcomerceApp.Models.ProductImage> ProductImages { get; set; }
    public DbSet<EcomerceApp.Models.ProductVariant> ProductVariants { get; set; }
    public DbSet<EcomerceApp.Models.Order> Orders { get; set; }
    public DbSet<EcomerceApp.Models.OrderItem> OrderItems { get; set; }
    public DbSet<EcomerceApp.Models.PaymentInfo> PaymentInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.GetTableName().StartsWith("AspNet"))
            {
                entityType.SetTableName(entityType.GetTableName().Substring(6));
            }
        }

        modelBuilder.Entity<ProductVariant>()
        .Property(pv => pv.Price)
        .HasColumnType("decimal(18, 2)");

        // Define relationships
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Images)
            .WithOne(pi => pi.Product)
            .HasForeignKey(pi => pi.ProductId);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Variants)
            .WithOne(pv => pv.Product)
            .HasForeignKey(pv => pv.ProductId);

        modelBuilder.Entity<Order>()
        .HasMany(o => o.Items)
        .WithOne(oi => oi.Order) // Chỉ định mối quan hệ một-nhiều giữa Order và OrderItem
        .HasForeignKey(oi => oi.OrderId); // Chỉ định OrderId là khóa ngoại cho OrderItem

        modelBuilder.Entity<Order>()
            .HasOne(o => o.ApplicationUser)
            .WithMany()
            .HasForeignKey(o => o.ApplicationUserId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.PaymentInfo)
            .WithOne()
            .HasForeignKey<PaymentInfo>(pi => pi.Id);

        modelBuilder.Entity<OrderItem>()
            .HasOne<ProductVariant>()
            .WithMany()
            .HasForeignKey(oi => oi.VariantId);

        modelBuilder.Entity<OrderItem>()
            .HasOne<Product>()
            .WithMany()
            .HasForeignKey(oi => oi.ProductId);
    }
   
}
