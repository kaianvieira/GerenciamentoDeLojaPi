using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.ToTable("TB_PRODUTO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("PRO_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.Tamanho)
                .HasColumnName("PRO_TAMANHO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Cor)
                .HasColumnName("PRO_COR")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.IdMarca)
                .HasColumnName("MAR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.IdFuncionario)
                .HasColumnName("FUN_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.IdSetor)
                .HasColumnName("SET_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.IdTipo)
                .HasColumnName("TIP_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(x => x.IdFornecedor)
                .HasColumnName("FOR_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.HasOne(x => x.Marca)
                .WithMany()
                .HasForeignKey(x => x.IdMarca);

            builder.HasOne(x => x.Funcionario)
                .WithMany()
                .HasForeignKey(x => x.IdFuncionario);

            builder.HasOne(x => x.Setor)
                .WithMany()
                .HasForeignKey(x => x.IdSetor);

            builder.HasOne(x => x.Tipo)
                .WithMany()
                .HasForeignKey(x => x.IdTipo);

            builder.HasOne(x => x.Fornecedor)
                .WithMany()
                .HasForeignKey(x => x.IdFornecedor);
        }
    }
}
