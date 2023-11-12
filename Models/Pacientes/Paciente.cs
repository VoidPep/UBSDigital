using UBSDigital.Models.Consultas;

namespace UBSDigital.Models.Pacientes;

public class Paciente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }
    public int Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public decimal Numero { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }

    public virtual ICollection<Consulta> Consultas { get; set; } = new HashSet<Consulta>();
}