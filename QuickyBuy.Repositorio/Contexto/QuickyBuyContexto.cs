using Microsoft.EntityFrameworkCore;
using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio.Contexto
{
    class QuickyBuyContexto: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

    }
}
