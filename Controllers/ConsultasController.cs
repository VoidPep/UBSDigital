using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using UBSDigital.Context;
using UBSDigital.Models.Consultas;
using UBSDigital.Models.Enums;
using UBSDigital.Requests;

namespace UBSDigital.Controllers;

public class ConsultasController : BaseApiController
{
    private readonly IAppDbContext _context;

    public ConsultasController(IAppDbContext context)
    {
        _context = context;
    }

    [HttpPost, Route("NovaConsulta")]
    public IActionResult NovaConsulta([FromBody] ConsultaRequest request)
    {
        var consulta = new Consulta
        {
            DataDaConsulta = DateTime.Now,
            Status = StatusDaConsulta.EM_ABERTO,
            IdPaciente = request.IdPaciente,
        };

        _context.Consultas.Add(consulta);
        _context.SaveChanges();

        return Ok();
    }

    [HttpPost, Route("AtualizarConsulta")]
    public IActionResult AtualizarConsulta([FromBody] ConsultaRequest request)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var consulta = _context.Consultas
            .AsNoTracking()
            .Include(q => q.Paciente)
            .Select(q => new
            {
                q.Id,
                Paciente = q.Paciente.Nome,
                Status = q.Status.GetDisplayName(),
                DataDeCriacao = q.DataDaConsulta,
                q.Diagnostico,
                q.Parecer,
            })
            .FirstOrDefault(q => q.Id == id);

        if (consulta == null)
            return NotFound("Não encontrado");

        return Ok(consulta);
    }
}
