using Domain.Base;
using Domain.Entities;
using Domain.Entities.Enums;
using System;
using TechTalk.SpecFlow;

namespace Domain.Tests
{
    [Binding]
    public class GerenciarCanaisDeComunicacaoStepDefinitions
    {
        private string NomeCanal;
        private TipoCanal TipoCanal;
        private Canal canal;


        [Given(@"que preciso cadastrar um canal de audio ou video")]
        public void GivenQuePrecisoCadastrarUmCanalDeAudioOuVideo()
        {
            //nao precisamos implementar...
        }

        [When(@"preencho o campo Nome com ""([^""]*)"" e o tipo como (.*)")]
        public void WhenPreenchoOCampoNomeComEOTipoComo(string p0, TipoCanal p1)
        {
            NomeCanal = p0;
            TipoCanal = p1;
        }

        [When(@"recebo os dados preenchidos pela tela")]
        public void WhenReceboOsDadosPreenchidosPelaTela()
        {
            Assert.Equal(NomeCanal, "Canal de Video");
            Assert.Equal(TipoCanal, TipoCanal.Video);
        }

        [Then(@"cadastro um novo Canal de video")]
        public void ThenCadastroUmNovoCanalDeVideo()
        {
            canal = new Canal(NomeCanal, TipoCanal);
        }

        [Then(@"o canal ""([^""]*)"" aparece na listagem de canais cadastrados")]
        public void ThenOCanalApareceNaListagemDeCanaisCadastrados(string p0)
        {
            Assert.Equal(NomeCanal, canal.Nome);
        }

        [Fact]
        public void Deve_Validar_Se_Nome_Do_Canal_Esta_Vazio_Retornar_Exception()
        {
            // Act & Assert
            var result = Assert.Throws<DomainException>(() => new Canal("", TipoCanal.Audio));
            Assert.Equal("O nome não pode estar vazio!", result.Message);
        }
    }
}
