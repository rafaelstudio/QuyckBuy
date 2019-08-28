using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio
{
     public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
