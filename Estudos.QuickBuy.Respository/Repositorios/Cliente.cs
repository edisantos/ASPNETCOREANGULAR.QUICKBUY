using Estudos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos.QuickBuy.Respository.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepository();
            var usuario = new Usuarios();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
