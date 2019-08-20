using Estudos.Domain.Entities;
using Estudos.Domain.ObjValue;
using Estudos.QuickBuy.Respository.EntityConfig;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos.QuickBuy.Respository.Contexto
{
    public class QuickBuyContexto:DbContext
    {
       

        //Class database
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaDePagamento> formaDePagamentos { get; set; }

        //Construtor
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //This will singularize all table names
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }
            modelBuilder.ApplyConfiguration(new UsuariosConfiguration());
            modelBuilder.ApplyConfiguration(new itemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidosConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuariosConfiguration());
            modelBuilder.ApplyConfiguration(new FormaDePagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
