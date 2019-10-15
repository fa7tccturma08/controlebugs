using ControleBugs.Helpers;
using ControleBugs.Helpers.VerificationPoint;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace ControleBugs.Steps
{
    [Binding]
    public class RealizarLoginSteps : LoginHelperVP
    {

        [BeforeFeature("RealizarLogin")]
        public static void AbrirApp()
        {
            AbrirAplicacao("http://localhost:8080/bugtracker-web/pages/login.xhtml");
        }

        [AfterFeature("RealizarLogin")]
        public static void FecharApp()
        {
            FecharAplicacao();
        }



        [When(@"eu preencho o '(.*)' e a '(.*)' validos")]
        public void QuandoEuPreenchoOEAValidos(string p0, string p1)
        {
            Login = "bugtracker";
            Senha = "bugtracker";
            PreencherCamposLogin(Login, Senha);
        }

        [When(@"seleciono a opcao logar")]
        public void QuandoSelecionoAOpcaoLogar()
        {
            SelecionarAOpcaoLogarNaS344();

        }

        [Then(@"o sistema retornara o sistema apresenta  a funcionalidade de edição de usuários")]
        public void EntaoOSistemaRetornaraOSistemaApresentaAFuncionalidadeDeEdicaoDeUsuarios()
        {
            Boolean LoginValido = verificarSeAEdicaoDeUsuarioEstaDisponivel();

            SelecionarAOpcaoSair();
            Assert.AreEqual(true, LoginValido);

        }

        [When(@"eu não preencho o ''(.*)''")]
        public void QuandoEuNaoPreenchoO(string p0)
        {
            Login = "";
            Senha = "";
           
            PreencherCamposLogin(Login, Senha);
        }

        [When(@"tento efetuar login no sistema")]
        public void QuandoTentoEfetuarLoginNoSistema()
        {
            SelecionarAOpcaoLogarNaS344();
        }

        [Then(@"o sistema retornara a mensagem ""(.*)""")]
        public void EntaoOSistemaRetornaraAMensagem(string p0)
        {
            string mensagemEsperada = "Login:campo é obrigatório";
            string mensagemAtual = GetMensagemLogin();

            Assert.AreEqual(mensagemEsperada, mensagemAtual);

        }


        [When(@"eu preencho o '(.*)' e a '(.*)' com valores invalidos")]
        public void QuandoEuPreenchoOEAComValoresInvalidos(string p0, int p1)
        {
            Login = "123";
            Senha = "321";
            
            PreencherCamposLogin(Login, Senha);
        }


        [Then(@"o sistema aresenta  mensagem ""(.*)""")]
        public void EntaoOSistemaAresentaMensagem(string p0)
        {
            string mensagemEsperada = "Login ou senha inválidos";
            string mensagemAtual = GetMensagemLogin();

            Assert.AreEqual(mensagemEsperada, mensagemAtual);
        }
    }
}
