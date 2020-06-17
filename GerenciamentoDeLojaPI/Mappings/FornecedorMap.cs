using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<FornecedorModel>
    {
        public void Configure(EntityTypeBuilder<FornecedorModel> builder)
        {
            builder.ToTable("TB_FORNECEDOR");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("FOR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("FOR_NOME")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
