using api.Models;
using api.Repositorios.Interfaces;

namespace api.ModelViews;

public class PessoaFisicaRepositorio : IServicoFisica
{
    private static List<PessoaFisica> lista = new List<PessoaFisica>();

    public List<PessoaFisica> Todos()
    {
        return lista;
    }

    public void Incluir(PessoaFisica pessoaFisica)
    {
        lista.Add(pessoaFisica);
    }

    public PessoaFisica Atualizar(PessoaFisica pessoaFisica)
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