using System.Collections.Generic;
using System.Linq;

namespace Estudos.Domain.Entities
{
    public abstract class Entidades
    {
        public List<string> _messageValidacao { get; set; }

        public  List<string> MessageValicao
        {
            get { return _messageValidacao ?? (_messageValidacao = new List<string>()); }
        }
        protected void LimparMessageValidacao()
        {
            MessageValicao.Clear();
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MessageValicao.Any(); }
            
        }
    }
}
