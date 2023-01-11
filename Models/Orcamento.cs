namespace api.Models;

public record Orcamento
{
    public int Id { get;set; } = default!;
    public int ClienteId { get;set; } = default!;
    public int FornecedorId { get;set; }
    public string DescricaoDoServico { get;set; } = default!;
    public float ValorTotal { get;set; } = default!;
    public DateTime DataCriacao { get;set; }
    public DateTime DataExpiracao { get;set; }
}
