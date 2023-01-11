using api.Models;

namespace api.Repositorios.Interfaces;

public interface IServicoFisica
{
    List<PessoaFisica> Todos();
    void Incluir(PessoaFisica pessoaFisica);
    PessoaFisica Atualizar(PessoaFisica pessoaFisica);
    void Apagar(PessoaFisica pessoaFisica);
}