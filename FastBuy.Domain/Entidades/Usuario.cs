using FastBuy.Domain.Entidades;
using System.Collections;
using System.Collections.Generic;

namespace FastBuy.Domain
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado.");
            
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada.");
        }
    }
}
