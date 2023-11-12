using UBSDigital.Models.Consultas;

namespace UBSDigital.Models.Pacientes;

public class UsuarioAmbulatorial
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }
    public virtual ICollection<Consulta> Consultas { get; set; } = new HashSet<Consulta>();
}
