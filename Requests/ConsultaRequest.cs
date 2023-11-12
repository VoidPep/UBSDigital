using UBSDigital.Models.Enums;

namespace UBSDigital.Requests;

public class ConsultaRequest
{
    public Guid? Id { get; set; }
    public StatusDaConsulta Status { get; set; }
    public DateTime DataDaConsulta { get; set; }
    public string? Diagnostico { get; set; }
    public string? Parecer { get; set; }

    public Guid IdPaciente { get; set; }
    public Guid? IdUsuarioAmbulatorial { get; set; }
}
