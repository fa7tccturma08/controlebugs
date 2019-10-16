

using ControleBugs.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ControleBugs.Helpers
{
  public class TelaHelper
    {

        public static IWebDriver Driver = new FirefoxDriver();
        private static int Timeout = Convert.ToInt32(ReadAppConfig.ReadSetting("timeout"));



        public void ClickObjet(IWebElement elemento)
        {

            elemento.Click();
        }

        public void SetText(IWebElement elemento, string strValue)
        {
            elemento.SendKeys(strValue.Trim());
        }


        public string GetText(IWebElement elemento)
        {
           return elemento.Text.Trim();
        }

        public string GetTextInnerText(IWebElement elemento)
        {
            return elemento.GetAttribute("innerText"); 
        }


        public void ClearText(IWebElement elemento)
        {
           
            elemento.Click();
            elemento.SendKeys("");
        }





        public void ImplicitWaintById(string htmlElement)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(Timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(htmlElement)));
        }

        public void ImplicitWaintByXpath(string htmlElement)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(Timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(htmlElement)));
        }

        public static void Sleep(int time)
        {
            Thread.Sleep(time*1000);
        }


    }
}