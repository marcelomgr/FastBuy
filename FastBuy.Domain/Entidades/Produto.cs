using System;
using System.Collections.Generic;
using System.Text;

namespace FastBuy.Domain.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Crítica: Nome não informado.");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Crítica: Descrição não informada.");

            if (Preco == 0)
                AdicionarCritica("Crítica: Preço não informado.");
        }
    }
}
