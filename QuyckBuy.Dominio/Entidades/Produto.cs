﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickyBuy.Dominio.Entidades
{
   public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validade()
        {
            

        }
    }
}