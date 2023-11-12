using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSDigital.Models.Consultas;

namespace UBSDigital.Types;

public class ConsultaTypeConfiguration : IEntityTypeConfiguration<Consulta>
{
    public void Configure(EntityTypeBuilder<Consulta> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(q => q.UsuarioAmbulatorial).WithMany(x => x.Consultas).HasForeignKey(q => q.IdUsuarioAmbulatorial);

        builder.HasMany(q => q.Anexos).WithOne(q => q.Consulta).HasForeignKey(q => q.IdConsulta);

        builder.Property(q => q.IdUsuarioAmbulatorial).IsRequired(false);
    }
}
