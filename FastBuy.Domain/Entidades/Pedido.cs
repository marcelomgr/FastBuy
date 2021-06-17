﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastBuy.Domain.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoComplemento { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica: Pedido não pode ficar sem ao menos um item.");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica: CEP deve ser preenchido.");
        }
    }
}
