using FastBuy.Domain.Entidades;
using System.Collections;
using System.Collections.Generic;

namespace FastBuy.Domain
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
