using FastBuy.Domain;
using FastBuy.Domain.Entidades;
using FastBuy.Repository.Repositorios;

namespace FastBuy.Repository
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepository = new UsuarioRepository();
            var usuario = new Usuario();

            usuarioRepository.Adicionar(usuario);
        }
    }
}
