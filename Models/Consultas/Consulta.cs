using System.ComponentModel.DataAnnotations.Schema;
using UBSDigital.Models.Enums;
using UBSDigital.Models.Pacientes;

namespace UBSDigital.Models.Consultas;

public class Consulta
{
    public Guid Id { get; set; }
    public StatusDaConsulta Status { get; set; }
    public DateTime DataDeAtualizacao { get; set; }
    public DateTime? DataDaConsulta { get; set; }
    public string? Diagnostico { get; set; }
    public string? Parecer { get; set; }

    public Guid IdPaciente { get; set; }
    public Guid? IdUsuarioAmbulatorial { get; set; }

    public virtual Paciente Paciente { get; set; }
    public virtual UsuarioAmbulatorial UsuarioAmbulatorial { get; set; }
    public virtual ICollection<AnexoDaConsulta> Anexos { get; set; } = new HashSet<AnexoDaConsulta>();
}