using Estudos.Domain.Entities;
using Estudos.Domain.ObjValue;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
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
    }
}
