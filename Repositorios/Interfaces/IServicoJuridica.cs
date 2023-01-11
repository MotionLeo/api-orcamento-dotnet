using api.Models;

namespace api.Repositorios.Interfaces;

public interface IServicoJuridica
{
    List<PessoaJuridica> Todos();
    void Incluir(PessoaJuridica pessoaJuridica);
    PessoaJuridica Atualizar(PessoaJuridica pessoaJuridica);
    void Apagar(PessoaJuridica pessoaJuridica);
}