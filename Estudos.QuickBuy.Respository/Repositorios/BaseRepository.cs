using Estudos.Domain.Contracts;
using System;
using System.Collections.Generic;

namespace Estudos.QuickBuy.Respository.Repositorios
{
    public class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public BaseRepository()
        {

        }
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        

        public TEntity obterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> obterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
