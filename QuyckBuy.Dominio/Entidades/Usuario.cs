using System.Collections;
using System.Collections.Generic;

namespace QuickyBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        //Usuario pode ter nunhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }


    }
}
