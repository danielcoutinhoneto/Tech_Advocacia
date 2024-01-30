using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Persistence.Configurations;

public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
{
   public void Configure(EntityTypeBuilder<Cliente> builder)
   {
      //configurações de mapeamento da entidade Paciente
      builder
         .ToTable("Cliente")
         .HasKey(m => m.ClienteId);
   }
}
