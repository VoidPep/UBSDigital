using Microsoft.AspNetCore.Mvc;
using UBSDigital.Context;
using UBSDigital.Models.Consultas;
using UBSDigital.Models.Pacientes;
using UBSDigital.Requests;

namespace UBSDigital.Controllers;

public class PacientesController : BaseApiController
{
    private readonly IAppDbContext _context;

    public PacientesController(IAppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var pacientes = _context.Pacientes.Select(q => new
        {
            q.Id,
            q.Nome,
            Endereco = new
            {
                q.Numero,
                q.Cep,
                q.Logradouro,
                q.Bairro,
                q.Cidade,
                q.Uf,
            },
            Consultas = q.Consultas.ToList().Count()
        });

        return Ok(pacientes);
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid? id)
    {
        var paciente = _context.Pacientes.Select(q => new
        {
            q.Id,
            q.Nome,
            Endereco = new
            {
                q.Numero,
                q.Cep,
                q.Logradouro,
                q.Bairro,
                q.Cidade,
                q.Uf,
            },
            Consultas = q.Consultas.ToList().Count()
        }).FirstOrDefault(q => q.Id == id);

        return Ok(paciente);
    }

    [HttpPost]
    public IActionResult Save([FromBody] PacienteRequest request)
    {
        var paciente = new Paciente
        {
            Id = request.Id == null ? Guid.Empty : request.Id.Value,
            Bairro = request.Bairro,
            Cep = request.Cep,
            Cidade = request.Cidade,
            Complemento = request.Complemento,
            Numero = request.Numero,
            Cpf = request.Cpf,
            Uf = request.Uf,
            Senha = request.Senha,
            Logradouro = request.Logradouro,
            Nome = request.Nome,
        };

        if (request.Id == Guid.Empty)
        {
            _context.Pacientes.Add(paciente);
        }
        else
        {
            _context.Pacientes.Update(paciente);
        }

        _context.SaveChanges();

        return Ok();
    }
}
