using Microsoft.EntityFrameworkCore;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Persistence;

public class TechAdvDbContext : DbContext
{
   public DbSet<Advogado> Advogados { get; set; }
   public DbSet<Cliente> Clientes { get; set; }

   public TechAdvDbContext(DbContextOptions<TechAdvDbContext> options) : base(options)
   {
      //Database.EnsureCreated();
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAdvDbContext).Assembly);
   }
}
