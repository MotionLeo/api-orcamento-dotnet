namespace api.Models;

public record PessoaFisica : Pessoa
{
    public string Cpf { get; set;} = default!;
}
