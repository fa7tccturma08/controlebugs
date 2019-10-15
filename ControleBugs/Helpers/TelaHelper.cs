

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



        public void clickObject(IWebElement elemento)
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



        public void implicitWaintById(string htmlElement)
        {
            var timeout = 10000; // in milliseconds
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(htmlElement)));
        }

        public void implicitWaintByXpath(string htmlElement)
        {
            var timeout = 10000; // in milliseconds
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(htmlElement)));
        }

        public static void sleep(int time)
        {
            Thread.Sleep(time*1000);
        }


    }
}