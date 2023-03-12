using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IList<Usuario> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
