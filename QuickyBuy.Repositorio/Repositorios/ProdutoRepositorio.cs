using QuickyBuy.Dominio.Entidades;
using QuickyBuy.Dominio.Contratos;
using QuickyBuy.Repositorio.Contexto;

namespace QuickyBuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickyBuyContexto quickyBuyContexto) : base(quickyBuyContexto)
        {

        }
    }
}
