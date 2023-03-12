using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static IList<Usuario> _usuarios = new List<Usuario>
        {
            new Usuario("Thiago S Adrino", "tadriano@gmail.com.br", "102030", new CPF("11111111111"), new Endereco("Rua A", "123", "Bairro A", "Cidade A", "Estado A", "11111-111"))
        };

        public IList<Usuario> GetUsers()
        {
            return _usuarios.ToList();
        }
    }
}
