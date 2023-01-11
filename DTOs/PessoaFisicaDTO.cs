using System.Text.Json.Serialization;

namespace api.DTOs;

public record PessoaFisicaDTO
{
    [JsonPropertyName("name")]
    public string Nome { get;set; } = default!;
    public string Cpf { get;set; } = default!;

    [JsonPropertyName("phone")]
    public string? Telefone { get;set; }

    [JsonPropertyName("creation date")]
    public DateTime DataCriacao { get;set; }
}