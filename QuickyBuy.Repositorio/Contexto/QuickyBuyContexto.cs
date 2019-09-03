using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Dominio.ObjetoDeValor;
using QuickyBuy.Repositorio.Config;

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

            modelBuilder.Entity<FormaPagamento>().HasData(
                    new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao="Forma de Pagamento Boleto" },
                    new FormaPagamento() { Id=2 ,Nome = "Cartao de Credito",Descricao="Forma de pagamento Cartao de Credito" },
                    new FormaPagamento() { Id = 3, Nome = "Deposito", Descricao = "Forma de pagamento Deposito" }
                    );

            base.OnModelCreating(modelBuilder);
        }

    }
}
