using OpenQA.Selenium;

namespace ControleBugs.Helpers
{
    public class LoginHelper : TelaHelper
    {
        

        public static void AbrirAplicacao(string URL)
        {

            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();


        }


        public void PreencherCamposLogin(string usuario, string senha)
        {

            IWebElement user = Driver.FindElement(By.Id("session_email"));
            IWebElement password = Driver.FindElement(By.Id("session_password"));

            ImplicitWaintById("session_email");

            ClickObjet(user);
            SetText(user, usuario);

            ImplicitWaintById("session_password");
            ClickObjet(password);
            SetText(password, senha);


        }

        public void SelecionarAOpcaoDeLogin()
        {
            IWebElement botaoLogar = Driver.FindElement(By.XPath("//input[@name='commit']"));
            ImplicitWaintByXpath("//input[@name='commit']");
            ClickObjet(botaoLogar);

        }

        public void SelecionarAOpcaoSair()
        {
            IWebElement linkSair = Driver.FindElement(By.XPath("//a[contains(text(),'Sign up')]"));
            ImplicitWaintByXpath("//a[contains(text(),'Sign up')]");
            ClickObjet(linkSair);
        }
        
        public static void FecharAplicacao()
        {

            Driver.Quit();

        }




    }
}
