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
            throw new NotImplementedException();
        }
    }
}
