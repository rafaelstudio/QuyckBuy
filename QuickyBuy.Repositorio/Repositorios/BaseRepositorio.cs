using QuickyBuy.Dominio.Contratos;
using QuickyBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickyBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly QuickyBuyContexto QuickyBuyContexto;

        public BaseRepositorio(QuickyBuyContexto quickyBuyContexto)
        {
            QuickyBuyContexto = quickyBuyContexto;
        }


        public void Adicionar(TEntity entity)
        {
            QuickyBuyContexto.Set<TEntity>().Add(entity);
            QuickyBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickyBuyContexto.Set<TEntity>().Update(entity);
            QuickyBuyContexto.SaveChanges();
        }

       

        public TEntity ObterPorId(int id)
        {
            return QuickyBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickyBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickyBuyContexto.Set<TEntity>().Remove(entity);
            QuickyBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            QuickyBuyContexto.Dispose();
        }
    }
}
