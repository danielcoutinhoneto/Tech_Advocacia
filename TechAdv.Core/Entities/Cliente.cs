namespace TechAdv.Core.Entities;

public class Cliente : Pessoa
{
    public int ClienteId {get; set;}
    public required string? EstadoCivil { get; set; }
    public required string? Profissao { get; set; }
}
