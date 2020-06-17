using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class CargoMap : IEntityTypeConfiguration<CargoModel>
    {
        public void Configure(EntityTypeBuilder<CargoModel> builder)
        {
            builder.ToTable("TB_CARGO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("CAR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("CAR_DESC")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);
        }
    }
}
