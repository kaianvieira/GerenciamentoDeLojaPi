using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoDeLojaPI.Mappings
{
    internal class FuncionarioMap : IEntityTypeConfiguration<FuncionarioModel>
    {
        public void Configure(EntityTypeBuilder<FuncionarioModel> builder)
        {
            builder.ToTable("TB_FUNCIONARIO");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id)
                .HasColumnName("FUN_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("FUN_NOME")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(e => e.IdCargo)
                .HasColumnName("CAR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.HasOne(e => e.Cargo)
                .WithMany()
                .HasForeignKey(e => e.IdCargo);
        }
    }
}
