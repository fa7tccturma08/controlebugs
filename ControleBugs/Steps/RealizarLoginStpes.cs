using ControleBugs.Helpers;
using System;
using TechTalk.SpecFlow;

namespace ControleBugs.Steps
{
    [Binding]
    public class LogarSteps : LoginHelper
    {

         
        [When(@"eu preencho o '(.*)' e a '(.*)' validos")]
        public void QuandoEuPreenchoOEAValidos(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seleciono a opcao logar")]
        public void QuandoSelecionoAOpcaoLogar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu não preencho o ''(.*)''")]
        public void QuandoEuNaoPreenchoO(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"tento efetuar login no sistema")]
        public void QuandoTentoEfetuarLoginNoSistema()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu preencho o '(.*)' e a '(.*)' com valores invalidos")]
        public void QuandoEuPreenchoOEAComValoresInvalidos(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu seleciono a opção para realizar logoff")]
        public void QuandoEuSelecionoAOpcaoParaRealizarLogoff()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o sistema retornara o sistema apresenta  a funcionalidade de edição de usuários")]
        public void EntaoOSistemaRetornaraOSistemaApresentaAFuncionalidadeDeEdicaoDeUsuarios()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o sistema retornara a mensagem ""(.*)""")]
        public void EntaoOSistemaRetornaraAMensagem(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o sistema aresenta  mensagem ""(.*)""")]
        public void EntaoOSistemaAresentaMensagem(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o sistema aresenta  a tela inicial para que seja efetuado o login")]
        public void EntaoOSistemaAresentaATelaInicialParaQueSejaEfetuadoOLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"as opções :""(.*)"",""(.*)"" e ""(.*)""")]
        public void EntaoAsOpcoesE(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
