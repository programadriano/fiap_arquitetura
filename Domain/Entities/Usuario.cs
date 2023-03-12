using Domain.Base;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Usuario : IAggregateRoot
    {
        public Usuario(string nome, string email, string senha, CPF cPF, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            CPF = cPF;
            Endereco = endereco;

            ValidateEntity();
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public CPF CPF { get; private set; }
        public Endereco Endereco { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Email, "O email não pode estar vazio!");
        }

    }

}
