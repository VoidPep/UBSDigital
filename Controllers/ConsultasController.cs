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
        var consulta = _context.Consultas.Find(request.Id);

        if (consulta == null)
            return NotFound("Não encontrado.");

        consulta.DataDeAtualizacao = DateTime.Now;

        consulta.Status = request.Status;
        consulta.IdUsuarioAmbulatorial = request.IdUsuarioAmbulatorial;
        consulta.Parecer = request.Parecer;
        consulta.Diagnostico = request.Diagnostico;

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

    [HttpPost, Route("AdicionarAnexos")]
    public IActionResult AdicionarAnexos([FromBody] AnexosRequest request)
    {
        var listaDeAnexosDaConsulta = new List<AnexoDaConsulta>();

        foreach (var anexo in request.Anexos)
        {
            listaDeAnexosDaConsulta.Add(new AnexoDaConsulta
            {
                UrlAnexo = anexo.Url,
                IdConsulta = anexo.IdConsulta
            });
        }

        _context.AnexosDasConsultas.AddRange(listaDeAnexosDaConsulta);
        _context.SaveChanges();

        return Ok();
    }
}
