using Estudos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Estudos.QuickBuy.Respository.EntityConfig
{
    public class PedidosConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataPedido)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2);

            builder.Property(p => p.EndecoCompleto)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(p => p.NumeroEndeco)
                .IsRequired()
                .HasColumnType("int");

            
        }
    }
}
