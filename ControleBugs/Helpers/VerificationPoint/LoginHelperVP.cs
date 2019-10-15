using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBugs.Helpers.VerificationPoint
{
    public class LoginHelperVP : LoginHelper
    {

        public Boolean verificarSeAEdicaoDeUsuarioEstaDisponivel()
        {
            implicitWaintById("nome");
            var campoNome = Driver.FindElement(By.Id("nome"));

            if (campoNome != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetMensagemLogin()
        {

            implicitWaintByXpath("//*[@id='mensagens']/li");
            var objMensagem = Driver.FindElement(By.Id("mensagens"));
            String MensagemTela = GetTextInnerText(objMensagem).Trim();

            if (objMensagem != null && MensagemTela != null)
            {
                return MensagemTela;
            }
            else
            {
                return "";
            }

        }
    }
}
