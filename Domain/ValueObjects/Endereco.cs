using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Endereco : ValueObject
    {

        public Endereco(string rua, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        public string Rua { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Rua;
            yield return Complemento;
            yield return Bairro;
            yield return Cidade;
            yield return Estado;
            yield return CEP;
        }
    }

}
