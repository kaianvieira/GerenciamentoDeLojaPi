using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class SetorMap : IEntityTypeConfiguration<SetorModel>
    {
        public void Configure(EntityTypeBuilder<SetorModel> builder)
        {
            builder.ToTable("TB_SETOR");

            builder.HasKey(e => e.Id);

            builder.Property(x => x.Id)
                .HasColumnName("SET_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("SET_NOME")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
