using QuickyBuy.Dominio.Contratos;
using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio.Repositorios
{
    class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickyBuyContexto quickyBuyContexto) : base(quickyBuyContexto)
        {
        }
    }
}

