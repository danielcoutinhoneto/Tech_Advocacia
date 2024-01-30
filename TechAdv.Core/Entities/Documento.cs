namespace TechAdv.Core.Entities;

public class Documento : BaseEntity
{
    public DateTimeOffset DataHoraModificacao { get; set; }
    public required int Codigo { get; set; }
    public required string? Tipo { get; set; }
    public required string? Descricao { get; set; }

}
