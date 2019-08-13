using System.Collections.Generic;
using System.Linq;

namespace Estudos.Domain.Entities
{
    public abstract class Entidades
    {
        public List<string> _messageValidacao { get; set; }

        private  List<string> MessageValidacao
        {
            get { return _messageValidacao ?? (_messageValidacao = new List<string>()); }
        }
        protected void LimparMessageValidacao()
        {
            MessageValidacao.Clear();
        }
        protected void AddCriticas(string mensagem)
        {
            MessageValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MessageValidacao.Any(); }
            
        }
    }
}
