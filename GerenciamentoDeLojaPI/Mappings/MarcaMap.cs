using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class MarcaMap : IEntityTypeConfiguration<MarcaModel>
    {
        public void Configure(EntityTypeBuilder<MarcaModel> builder)
        {
            builder.ToTable("TB_MARCA");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id)
                .HasColumnName("MAR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("MAR_NOME")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
