using System.Reflection.Metadata.Ecma335;

namespace UBSDigital.Models.Consultas;

public class AnexoDaCosnulta
{

    public Guid IdConsulta { get; set; }
    public string UrlAnexo { get; set; }

    public virtual Consulta Consulta { get; set; }
}
