using Domain.Entities;

namespace Application.UseCases
{
    public interface IUserUseCase
    {
        IList<Usuario> GetUsers();

    }
}
