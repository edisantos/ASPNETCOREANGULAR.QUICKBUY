using Estudos.Domain.Contracts;
using Estudos.Domain.Entities;

namespace Estudos.QuickBuy.Respository.Repositorios
{
    public class UsuarioRepository:BaseRepository<Usuarios>,IUsuarioRepository
    {
        public UsuarioRepository()
        {

        }
    }
}
