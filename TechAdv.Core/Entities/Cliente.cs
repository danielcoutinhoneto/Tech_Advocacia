namespace TechAdv.Core.Entities;

public class Cliente : Pessoa
{
    public required string? EstadoCivil { get; set; }
    public required string? Profissao { get; set; }
}
