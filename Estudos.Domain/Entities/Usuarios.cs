﻿using System.Collections.Generic;

namespace Estudos.Domain.Entities
{
    public class Usuarios:Entidades
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// ESTA ESTANCIA DE USUÁRIOS PODE TER 0 OU MUITOS PEDIDOS
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AddCriticas("E-mail não informada");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AddCriticas("Senha não informada");
            }
        }
    }
}
