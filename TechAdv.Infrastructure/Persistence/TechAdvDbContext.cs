using Microsoft.EntityFrameworkCore;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Persistence;

public class TechAdvDbContext : DbContext
{
   public DbSet<Advogado> Advogados { get; set; }
   public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "server=localhost;user=root;password=Tic123456;database=techadvocacia";
        var serverVersion = ServerVersion.AutoDetect(connectionString);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

       modelBuilder.Entity<Advogado>().ToTable("Advogado").HasKey(a => a.AdvogadoId);
       modelBuilder.Entity<Cliente>().ToTable("Cliente").HasKey(c => c.ClienteId);
   }
}
