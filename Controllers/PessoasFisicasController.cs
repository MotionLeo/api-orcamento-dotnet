using Microsoft.AspNetCore.Mvc;
using api.ModelViews;
using api.Models;
using api.Repositorios.Interfaces;
using api.DTOs;
using api.Servicos;

namespace api.Controllers;

[Route("fisicas")]
public class PessoasFisicasController : ControllerBase
{
    private IServicoFisica _servico;
    public PessoasFisicasController(IServicoFisica servico)
    {
        _servico = servico;
    }
    // GET: Clientes
    [HttpGet("")]
    public IActionResult Index()
    {
        var pessoaFisica = _servico.Todos();
        return StatusCode(200, pessoaFisica);
    }

    [HttpGet("{id}")]
    public IActionResult Details([FromRoute] int id)
    {
       var pessoaFisica = _servico.Todos().Find(p => p.Id == id);

        return StatusCode(200, pessoaFisica);
    }

    
    // POST: Clientes
    [HttpPost("")]
    public IActionResult Create([FromBody] PessoaFisica pessoaFisica)
    {
        _servico.Incluir(pessoaFisica);
        return StatusCode(201, pessoaFisica);
    }


    // PUT: Clientes/5
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] PessoaFisica pessoaFisica)
    {
        if (id != pessoaFisica.Id)
        {
            return StatusCode(400, new {
                Mensagem = "O Id do cliente precisa bater com o id da URL"
            });
        }

        var pessoaFisicaDb = _servico.Atualizar(pessoaFisica);

        return StatusCode(200, pessoaFisicaDb);
    }

    // POST: Clientes/5
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var pessoaFisicaDb = _servico.Todos().Find(p => p.Id == id);
        if(pessoaFisicaDb is null)
        {
            return StatusCode(404, new {
                Mensagem = "O cliente informado não existe"
            });
        }

        _servico.Apagar(pessoaFisicaDb);

        return StatusCode(204);
    }
}
