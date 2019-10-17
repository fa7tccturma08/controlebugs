

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
        private static readonly int Timeout = Convert.ToInt32(ReadAppConfig.ReadSetting("timeout"));
        private static readonly WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(Timeout));


        public static void ClickObjet(string StrProp, string StrValue)
        {
            var elemento = GetElement(StrProp, StrValue);
            elemento.Click();
        }

        public static void SetText(string StrProp, string StrValue,string Value)
        {
            var elemento = GetElement(StrProp, StrValue);
            elemento.SendKeys(Value.Trim());
        }


        public static string GetText(string StrProp, string StrValue)
        {
            var elemento = GetElement(StrProp, StrValue);
            return elemento.Text.Trim();
        }

        public string GetTextInnerText(string StrProp, string StrValue)
        {
            var elemento = GetElement(StrProp, StrValue);
            return elemento.GetAttribute("innerText");
        }

        public static string GetAtribute(string StrProp, string StrValue,string Atribute)
        {
            var elemento = GetElement(StrProp, StrValue);
            return elemento.GetAttribute(Atribute.Trim());
        }


        public static void ClearText(string StrProp, string StrValue)
        {

            var elemento = GetElement(StrProp, StrValue);   
            elemento.Click();
            elemento.Clear();
        }


        public static void WaintPresenceOfAllElementsLocated(string StrProp, string StrValue)
        {
            if (StrProp.Trim() == ".id")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id(StrValue.Trim())));
            }else if (StrProp.Trim() == ".name")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Name(StrValue.Trim())));
            }else if (StrProp.Trim() == ".className")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName(StrValue.Trim())));
            }
            else if (StrProp.Trim() == ".tagName")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName(StrValue.Trim())));
            }
            else if (StrProp.Trim() == ".linkText")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.LinkText(StrValue.Trim())));
            }
            else if (StrProp.Trim() == ".cssSelector")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector(StrValue.Trim())));
            }
            else if (StrProp.Trim() == ".partialLinkText")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.PartialLinkText(StrValue.Trim())));
            }
            else if (StrProp.Trim() == ".xPath")
            {
                Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(StrValue.Trim())));
            }
        }


        public static IWebElement GetElement(string StrProp, string StrValue)
        {

            WaintPresenceOfAllElementsLocated(StrProp, StrValue);
            if (StrProp.Trim() == ".id")
            {
                return Driver.FindElement(By.Id(StrValue));
            }
            else if (StrProp.Trim() == ".name")
            {
                return Driver.FindElement(By.Name(StrValue));
            }
            else if (StrProp.Trim() == ".className")
            {
                return Driver.FindElement(By.ClassName(StrValue));
            }
            else if (StrProp.Trim() == ".tagName")
            {
                return Driver.FindElement(By.TagName(StrValue));
            }
            else if (StrProp.Trim() == ".linkText")
            {
                return Driver.FindElement(By.LinkText(StrValue));
            }
            else if (StrProp.Trim() == ".cssSelector")
            {
                return Driver.FindElement(By.CssSelector(StrValue));
            }
            else if (StrProp.Trim() == ".partialLinkText")
            {
                return Driver.FindElement(By.PartialLinkText(StrValue));
            }
            else if (StrProp.Trim() == ".xPath")
            {
                return Driver.FindElement(By.XPath(StrValue));
            }
            else
            {
                return null;
            }
        }




        public static void Sleep(int time)
        {
            Thread.Sleep(time * 1000);
        }


    }
}