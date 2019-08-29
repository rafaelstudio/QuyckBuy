using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickyBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(Pr => Pr.Id);

            builder
                .Property(Pr => Pr.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(Pr => Pr.Preco)
                .IsRequired();
            builder
                .Property(Pr => Pr.Descricao)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
