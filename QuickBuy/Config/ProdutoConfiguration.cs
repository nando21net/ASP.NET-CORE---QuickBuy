using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.Preco)
                .IsRequired();
                
        }
    }
}
