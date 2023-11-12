using System.ComponentModel.DataAnnotations.Schema;
using UBSDigital.Models.Enderecos;
using UBSDigital.Models.Enums;

namespace UBSDigital.Models.Usuarios;

public class Usuario
{
    public Guid Id { get; set; }
    [ForeignKey("Endereco")]
    public Guid IdEndereco { get; set; }
    public TipoDePerfil Perfil { get; set; }
    public string Nome { get; set; }
    public string? Crm { get; set; }
    public string Cpf { get; set; }
    public string Senha { get; set; }
    public virtual Endereco Endereco { get; set; }
}