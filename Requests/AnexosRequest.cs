namespace UBSDigital.Requests;

public class AnexosRequest
{
    public List<Anexo> Anexos { get; set; }
}
public class Anexo
{
    public Guid IdConsulta { get; set; }
    public string Url { get; set; }
}