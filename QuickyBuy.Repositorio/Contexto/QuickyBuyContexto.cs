using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Dominio.ObjetoDeValor;
using QuickyBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio.Contexto
{
    public class QuickyBuyContexto: DbContext
    {
        

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickyBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de Mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
