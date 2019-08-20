using Estudos.Domain.ObjValue;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Estudos.QuickBuy.Respository.EntityConfig
{
    public class FormaDePagamentoConfiguration :IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            builder.ToTable("FormaDePagamento");
            builder.HasKey(f => f.Id);
            builder.Property(p => p.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
