namespace TechAdv.Core.Entities;

public class Advogado : Pessoa
{
    public int AdvogadoId {get; set;}
    public required string? CNA { get; set; }
}
