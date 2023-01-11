using Microsoft.AspNetCore.Mvc;
using api.ModelViews;
using api.Models;
using api.Repositorios.Interfaces;
using api.DTOs;
using api.Servicos;

namespace api.Controllers;

[Route("juridicas")]
public class PessoasJuridicasController : ControllerBase
{
    private IServicoJuridica _servico;
    public PessoasJuridicasController (IServicoJuridica servicoJuridica)
    {
        _servico = servicoJuridica;
    }
    // GET: Clientes
    [HttpGet("")]
    public IActionResult Index()
    {
        var pessoaJuridica = _servico.Todos();
        return StatusCode(200, pessoaJuridica);
    }

    [HttpGet("{id}")]
    public IActionResult Details([FromRoute] int id)
    {
       var pessoaJuridica = _servico.Todos().Find(p => p.Id == id);

        return StatusCode(200, pessoaJuridica);
    }

    
    // POST: Clientes
    [HttpPost("")]
    public IActionResult Create([FromBody] PessoaJuridica pessoaJuridica)
    {
        _servico.Incluir(pessoaJuridica);
        return StatusCode(201, pessoaJuridica);
    }


    // PUT: Clientes/5
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] PessoaJuridica pessoaJuridica)
    {
        if (id != pessoaJuridica.Id)
        {
            return StatusCode(400, new {
                Mensagem = "O Id do fornecedor precisa bater com o id da URL"
            });
        }

        var pessoaJuridicaDb = _servico.Atualizar(pessoaJuridica);

        return StatusCode(200, pessoaJuridicaDb);
    }

    // POST: Clientes/5
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var pessoaJuridicaDb = _servico.Todos().Find(p => p.Id == id);
        if(pessoaJuridicaDb is null)
        {
            return StatusCode(404, new {
                Mensagem = "O fornecedor informado não existe"
            });
        }

        _servico.Apagar(pessoaJuridicaDb);

        return StatusCode(204);
    }
}
