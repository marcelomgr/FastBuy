﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FastBuy.Domain.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidada { get; set; }
    }
}
