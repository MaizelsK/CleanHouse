using CleanHouse.PersistancyLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanHouse.PersistancyLayer
{
  public class AppDbContext : IdentityDbContext<AppUser>
  {
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) { }

    public DbSet<House> Houses { get; }

    public DbSet<Space> Spaces { get; }

    public DbSet<SpaceElement> SpaceElements { get; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AppUser>(buildAction =>
      {
        buildAction.HasKey(nameof(AppUser.Id));
      });

      builder.Entity<House>(buildAction =>
      {
        buildAction.ToTable("House");

        buildAction.HasKey(nameof(House.Id));
        buildAction.HasMany<Space>(nameof(House.Spaces));
      });

      builder.Entity<Space>(buildAction =>
      {
        buildAction.ToTable("Space");

        buildAction.HasKey(nameof(Space.Id));
        buildAction.HasMany<SpaceElement>(nameof(Space.Elements));
      });

      builder.Entity<SpaceElement>(buildAction =>
      {
        buildAction.HasKey(nameof(SpaceElement.Id));
      });
    }
  }
}
