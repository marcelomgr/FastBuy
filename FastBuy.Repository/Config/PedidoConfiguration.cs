using FastBuy.Domain;
using FastBuy.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastBuy.Repository.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pe => pe.Id);

            builder
                .Property(pe => pe.DataPedido)
                .IsRequired();

            builder
                .Property(pe => pe.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(pe => pe.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(pe => pe.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(pe => pe.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(pe => pe.EnderecoComplemento)
                .IsRequired()
                .HasMaxLength(100);


            builder
                .Property(u => u.NumeroEndereco)
                .IsRequired();
        }
    }
}
