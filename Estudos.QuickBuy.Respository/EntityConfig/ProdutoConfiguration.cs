using Estudos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Estudos.QuickBuy.Respository.EntityConfig
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Descricao)
               .HasColumnType("varchar")
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(p => p.Preco)
               .HasColumnType("decimal")
               .IsRequired();
               
        }
    }
}
