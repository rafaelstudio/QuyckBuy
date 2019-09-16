using QuickyBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
         Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
