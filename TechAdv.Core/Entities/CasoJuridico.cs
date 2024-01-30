namespace TechAdv.Core.Entities;

public class CasoJuridico : BaseEntity
{
    public required DateTimeOffset AberturaData { get; set; }
    public required float ProbabilidadeDeSucesso { get; set; }
    public required DateTimeOffset EncerramentoData { get; set; }
    public required string? Status { get; set; }
}
