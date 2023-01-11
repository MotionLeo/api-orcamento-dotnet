using api.Models;

namespace api.Repositorios.Interfaces;

public interface IServico<T>
{
    List<T> Todos();
    void Incluir(T obj);
    T Atualizar(int id);
    void Apagar(int id);
}