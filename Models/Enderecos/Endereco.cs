using System.ComponentModel.DataAnnotations;
using UBSDigital.Models.Usuarios;

namespace UBSDigital.Models.Enderecos;

public class Endereco
{
    public Guid Id { get; set; }
    public int Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public decimal Numero { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    [StringLength(2)]
    public string Uf { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
}
