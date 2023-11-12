using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSDigital.Models.Pacientes;

namespace UBSDigital.Types;

public class PacienteTypeConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasMany(q => q.Consultas).WithOne(q => q.Paciente).HasForeignKey(q => q.IdPaciente);
    }
}

