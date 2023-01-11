using api.Models;
using api.Repositorios.Interfaces;

namespace api.ModelViews;

public class PessoaFisicaRepositorio<T> : IServico<T>
{
    private static List<IServico<PessoaFisica>> lista = new List<IServico<PessoaFisica>>();

    public List<IServico<PessoaFisica>> Todos()
    {
        return lista;
    }

    public void Incluir(IServico<PessoaFisica> pessoaFisica)
    {
        lista.Add(pessoaFisica);
    }

    public IServico<PessoaFisica> Atualizar(IServico<PessoaFisica> pessoaFisica)
    {
        if(pessoaFisica.Id == 0) throw new Exception("Id não pode ser zero");

        var pessoaFisicaDb = lista.Find(p => p.Id == pessoaFisica.Id);
        if(pessoaFisicaDb is null)
        {
            throw new Exception("O cliente informado não existe");
        }

        pessoaFisicaDb.Nome = pessoaFisica.Nome;
        pessoaFisicaDb.Telefone = pessoaFisica.Telefone;
        pessoaFisicaDb.Cpf = pessoaFisica.Cpf;
        pessoaFisicaDb.DataCriacao = pessoaFisica.DataCriacao;
        return pessoaFisicaDb;
    }

    public void Apagar(PessoaFisica pessoaFisica)
    {
        lista.Remove(pessoaFisica);
    }
}