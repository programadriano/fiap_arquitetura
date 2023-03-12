using Domain.Base;

namespace Domain.Entities
{
    public class RedeSocial : IAggregateRoot
    {
        public RedeSocial(string nome, string uRL, string token)
        {
            Nome = nome;
            URL = uRL;
            Token = token;
        }

        public string Nome { get; private set; }
        public string URL { get; private set; }
        public string Token { get; private set; }
    }
}
