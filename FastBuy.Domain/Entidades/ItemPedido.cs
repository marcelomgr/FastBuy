using System;
using System.Collections.Generic;
using System.Text;

namespace FastBuy.Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidada { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
