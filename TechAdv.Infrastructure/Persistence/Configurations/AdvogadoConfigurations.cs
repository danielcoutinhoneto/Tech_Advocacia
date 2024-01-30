using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdv.Core.Entities;

namespace TechAdv.Infrastructure.Persistence.Configurations;

public class AdvogadoConfigurations : IEntityTypeConfiguration<Advogado>
{
   public void Configure(EntityTypeBuilder<Advogado> builder)
   {
      //configurações de mapeamento da entidade Medico
      builder
         .ToTable("Advogados")
         .HasKey(m => m.AdvogadoId);
   }
}
