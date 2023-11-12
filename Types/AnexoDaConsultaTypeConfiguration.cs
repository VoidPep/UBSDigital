using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSDigital.Models.Consultas;

namespace UBSDigital.Types;

public class AnexoDaConsultaTypeConfiguration : IEntityTypeConfiguration<AnexoDaConsulta>
{
    public void Configure(EntityTypeBuilder<AnexoDaConsulta> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
