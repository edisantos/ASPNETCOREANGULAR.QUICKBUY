﻿namespace Estudos.Domain.Entities
{
    public class ItemPedido:Entidades
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
