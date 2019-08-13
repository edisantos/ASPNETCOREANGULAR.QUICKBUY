using Estudos.Domain.ObjValue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Estudos.Domain.Entities
{
    public class Pedido:Entidades
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string EndecoCompleto { get; set; }
        public int NumeroEndeco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        /// <summary>
        /// PEDIDOS DEVE TER 1 OU MUITOS ITENS DE PEDIDOS
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMessageValidacao();
            if (!ItensPedidos.Any())
            {
                AddCriticas("Alerta! Pedido não pode ficar sem item de pedido");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AddCriticas("Alerta! CEP não pode ser em branco");
            }
               
            
          
        }
    }
}
