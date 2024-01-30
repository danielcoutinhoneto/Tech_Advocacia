namespace TechAdv.Core.Entities;

public abstract class Pessoa : BaseEntity
{
    public required string Nome {get; set;}
    public required string CPF {get; set;}
    public required DateTimeOffset DataNascimento {get; set;}
}
