using System.ComponentModel.DataAnnotations.Schema;

namespace UBSDigital.Models.Consultas;

public class AnexoDaConsulta
{
    public Guid Id { get; set; }
    public Guid IdConsulta { get; set; }
    public string UrlAnexo { get; set; }

    public virtual Consulta Consulta { get; set; }
}
