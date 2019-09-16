using QuickyBuy.Dominio.Contratos;
using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickyBuy.Repositorio.Repositorios
{
    public  class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickyBuyContexto quickyBuyContexto) : base(quickyBuyContexto)
        {          
        }

        public Usuario Obter(string email, string senha)
        {
            return QuickyBuyContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return QuickyBuyContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}

