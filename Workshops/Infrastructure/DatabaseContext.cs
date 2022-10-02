using Microsoft.EntityFrameworkCore;
using Workshops.Entities;

namespace Workshops.Infrastructure;

public sealed class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    { }

    public DbSet<Workshop> Workshops => Set<Workshop>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Workshop>(entity =>
        {
            entity.ToTable("Workshops");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(256).IsRequired();
            entity.Property(t => t.Date).IsRequired();
        });

        modelBuilder.Entity<Workshop>().HasData(
            new Workshop(Guid.Parse("258492AE-0133-47FC-B3F1-75C0AC33A291"), "Workshop Azure Network", DateTime.Now.AddDays(15)),
            new Workshop(Guid.Parse("F55ADD9C-350A-4B14-BD1D-F13ACA067846"), "Workshop Terraform", DateTime.Now.AddDays(30)),
            new Workshop(Guid.Parse("E867C517-CE35-4FE5-8CAE-B944DBFD9D54"), "Workshop Azure Kubernetes Service", DateTime.Now.AddDays(45)),
            new Workshop(Guid.Parse("F2B16552-389A-442C-A176-EE46B3CE53A7"), "Workshop Azyre Container Instance", DateTime.Now.AddDays(60)),
            new Workshop(Guid.Parse("952347F8-11AF-4BF3-AB62-91E9794D56EC"), "Workshop Azure Firewall", DateTime.Now.AddDays(75)),
            new Workshop(Guid.Parse("59D1E381-5484-4580-9EB4-8FC364075225"), "Workshop Azure Cognitive Services", DateTime.Now.AddDays(90))
        );
    }
}
