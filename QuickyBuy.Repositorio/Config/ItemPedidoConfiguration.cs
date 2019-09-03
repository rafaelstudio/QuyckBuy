using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickyBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(it => it.Id);


            builder
                .Property(i => i.ProdutoId)
                .IsRequired();
            builder
                .Property(i => i.Quantidade)
                .IsRequired();
                

            
        }
    }
}
