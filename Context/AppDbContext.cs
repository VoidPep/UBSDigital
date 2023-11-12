using System.Reflection;
using Microsoft.EntityFrameworkCore;
using UBSDigital.Models.Consultas;
using UBSDigital.Models.Pacientes;

namespace UBSDigital.Context;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<AnexoDaConsulta> AnexosDasConsultas { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<UsuarioAmbulatorial> UsuariosAmbulatoriais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        ChangeTracker.DetectChanges();

        return base.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        ChangeTracker.DetectChanges();

        return await base.SaveChangesAsync();
    }
}
