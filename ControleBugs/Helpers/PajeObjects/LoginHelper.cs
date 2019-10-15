using OpenQA.Selenium;

namespace ControleBugs.Helpers
{
    public class LoginHelper : TelaHelper
    {
        public string Login = "";
        public string Senha = "";

        public static void AbrirAplicacao(string URL)
        {

            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();


        }


        public void PreencherCamposLogin(string usuario, string senha)
        {

            IWebElement user = Driver.FindElement(By.Id("campoLogin"));
            IWebElement password = Driver.FindElement(By.Id("campoSenha"));

            implicitWaintById("campoLogin");

            clickObject(user);
            SetText(user, usuario);

            implicitWaintById("campoSenha");
            clickObject(password);
            SetText(password, senha);


        }

        public void SelecionarAOpcaoLogarNaS344()
        {
            IWebElement botaoLogar = Driver.FindElement(By.Id("btnLogar"));
            implicitWaintById("btnLogar");
            clickObject(botaoLogar);

        }

        public void SelecionarAOpcaoSair()
        {
            IWebElement linkSair = Driver.FindElement(By.Id("linkSair"));
            implicitWaintById("linkSair");
            clickObject(linkSair);
        }
        
        public static void FecharAplicacao()
        {

            Driver.Quit();

        }




    }
}
