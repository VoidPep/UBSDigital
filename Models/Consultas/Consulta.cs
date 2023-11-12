using UBSDigital.Models.Enums;
using UBSDigital.Models.Usuarios;

namespace UBSDigital.Models.Consultas;

public class Consulta
{
    public Guid Id { get; set; }
    public StatusDaConsulta Status { get; set; }
    public DateTime DataDaConsulta { get; set; }
    public string? Diagnostico { get; set; }
    public string? PrescricoesMedicas { get; set; }

    public Guid IdPaciente { get; set; }
    public Guid? IdMedico { get; set; }

    public virtual Usuario Paciente { get; set; }
    public virtual Usuario UsuarioAmbulatorial { get; set; }
}