using Estudos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Estudos.QuickBuy.Respository.EntityConfig
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
       
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(u => u.Id);
            builder.Property(p => p.Email)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar");

            builder.Property(p => p.Senha)
               .HasMaxLength(400)
               .IsRequired()
               .HasColumnType("varchar");

            builder.Property(p => p.Nome)
               .HasMaxLength(50)
               .IsRequired()
               .HasColumnType("varchar");

            builder.Property(p => p.SobreNome)
              .HasMaxLength(50)
              .IsRequired()
              .HasColumnType("varchar");

            //builder.Property(p => p.Pedidos);
            builder.HasMany(p => p.Pedidos)
                .WithOne(p => p.Usuarios);
                
        }
    }
}
