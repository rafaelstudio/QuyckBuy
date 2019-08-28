using QuickyBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickyBuy.Dominio.Entidades
{
   public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



        //Pedido teve ter pelo meno um item de pedido
        //ou muitos itens de pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (ItensPedido.Any())
                AdicionarCritica("Erro: Pedido não pode ficar sem itens de pedido");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Erro: - O campo cep não pode estar vazio");
        }
    }
}
