﻿namespace Estudos.Domain.Entities
{
    public class Produto:Entidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

    }
}
