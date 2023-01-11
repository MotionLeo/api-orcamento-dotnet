using api.Models;
using api.Repositorios.Interfaces;

namespace api.ModelViews;

public class PessoaJuridicaRepositorio : IServicoJuridica
{
    private static List<PessoaJuridica> lista = new List<PessoaJuridica>();

    public List<PessoaJuridica> Todos()
    {
        return lista;
    }

    public void Incluir(PessoaJuridica pessoaJuridica)
    {
        lista.Add(pessoaJuridica);
    }

    public PessoaJuridica Atualizar(PessoaJuridica pessoaJuridica)
    {
        if(pessoaJuridica.Id == 0) throw new Exception("Id não pode ser zero");

        var pessoaJuridicaDb = lista.Find(p => p.Id == pessoaJuridica.Id);
        if(pessoaJuridicaDb is null)
        {
            throw new Exception("O fornecedor informado não existe");
        }

        pessoaJuridicaDb.Nome = pessoaJuridica.Nome;
        pessoaJuridicaDb.Telefone = pessoaJuridica.Telefone;
        pessoaJuridicaDb.Cnpj = pessoaJuridica.Cnpj;
        pessoaJuridicaDb.DataCriacao = pessoaJuridica.DataCriacao;
        return pessoaJuridicaDb;
    }

    public void Apagar(PessoaJuridica pessoaJuridica)
    {
        lista.Remove(pessoaJuridica);
    }
}
