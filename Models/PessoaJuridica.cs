namespace api.Models;

public record PessoaJuridica : Pessoa
{
    public string Cnpj { get; set;} = default!;
}
