using Microsoft.EntityFrameworkCore;
using UBSDigital.Models.Consultas;
using UBSDigital.Models.Pacientes;

namespace UBSDigital.Context;

public interface IAppDbContext
{
    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<AnexoDaConsulta> AnexosDasConsultas { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<UsuarioAmbulatorial> UsuariosAmbulatoriais { get; set; }
}
