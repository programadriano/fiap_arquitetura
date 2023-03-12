using Domain.Base;

namespace Domain.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF(string cnpj)
        {
            Numero = cnpj;
        }

        public string Numero { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Numero;
        }
    }

}
