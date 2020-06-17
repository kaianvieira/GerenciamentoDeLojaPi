using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class TipoMap : IEntityTypeConfiguration<TipoModel>
    {
        public void Configure(EntityTypeBuilder<TipoModel> builder)
        {
            builder.ToTable("TB_TIPO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("TIP_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("TIP_NOME")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
