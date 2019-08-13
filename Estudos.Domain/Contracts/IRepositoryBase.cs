using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> :IDisposable where TEntity:class
    {
        void Adicionar(TEntity entity);
        TEntity obterPorId(int id);

        IEnumerable<TEntity> obterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);

    }
}
