using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSDigital.Models.Pacientes;

namespace UBSDigital.Types;

public class UsuarioAmbulatorialTypeConfiguration : IEntityTypeConfiguration<UsuarioAmbulatorial>
{
    public void Configure(EntityTypeBuilder<UsuarioAmbulatorial> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasMany(q => q.Consultas).WithOne(q => q.UsuarioAmbulatorial).HasForeignKey(q => q.IdUsuarioAmbulatorial);
    }
}
