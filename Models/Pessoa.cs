namespace api.Models;

public record Pessoa
{
    public int Id { get;set; } = default!;
    public string Nome { get;set; } = default!;
    public string? Telefone { get;set; }
    public DateTime DataCriacao { get;set; }
}
