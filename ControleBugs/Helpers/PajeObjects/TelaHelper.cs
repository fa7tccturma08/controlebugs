using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace ControleBugs.Helpers.PajeObjects
{
    public class TelaHelper
    {

        public static IWebDriver Driver = new FirefoxDriver();

        public void LoginPrompt(String user, String senha, String url)
        {

            LoadURL(url);
            var sim = new InputSimulator();
            sim.Keyboard
              .Sleep(3000)
              .TextEntry(user)
              .KeyPress(VirtualKeyCode.TAB)
                .TextEntry(senha)
               .KeyPress(VirtualKeyCode.RETURN)
               .Sleep(1000);
            MaximizeBrowser();
        }

       


        public String getCell(String strType, String strValue, int row, int col)
        {

            IWebElement tabela = GetIWebElement(strType, strValue);

            List<IWebElement> tr = tabela.FindElements(By.CssSelector("tr")).ToList();
            List<IWebElement> td = tabela.FindElements(By.CssSelector("td")).ToList();

            int rows = tr.Count;
            int cols = td.Count;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (x == row && y == col)
                    {
                        var str = td[y].Text.Trim();
                        return str;
                    }
                }
            }
            return "Do not elements find";

        }


        public int getRowCount(String strType, String strValue, int row, int col)
        {

            IWebElement tabela = GetIWebElement(strType, strValue);

            List<IWebElement> tr = tabela.FindElements(By.CssSelector("tr")).ToList();
            return tr.Count;
        }


        public int getColumnCount(String strType, String strValue, int row, int col)
        {

            IWebElement tabela = GetIWebElement(strType, strValue);

            List<IWebElement> td = tabela.FindElements(By.CssSelector("td")).ToList();
            return td.Count;
        }

        public void setCell(String strType, String strValue, int row, int col, String value)
        {

            IWebElement tabela = GetIWebElement(strType, strValue);

            List<IWebElement> tr = tabela.FindElements(By.CssSelector("tr")).ToList();
            List<IWebElement> td = tabela.FindElements(By.CssSelector("td")).ToList();

            int rows = tr.Count;
            int cols = td.Count;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (x == row && y == col)
                    {
                        td[y].SendKeys(value);


                    }
                }
            }


        }



        public Boolean verifyCheckBox(String strType, String strValue)
        {

            Boolean isSelect = GetIWebElement(strType, strValue).Selected;
            return isSelect;
        }

        public Boolean verifyRadioBox(String strType, String strValue)
        {

            Boolean isSelect = GetPropertyObect(strType, strValue, "checked").Equals("checked");
            return isSelect;
        }


        public void ClickObject(String strType, String strValue)
        {
            var elemento = GetIWebElement(strType, strValue);
            elemento.Click();
        }

        public void SetText(String strType, String strValue, String strValueText)
        {
            var elemento = GetIWebElement(strType, strValue);
            elemento.SendKeys(strValueText.Trim());
        }

        public Boolean IsPropertyObjectIguaisVerify(String strType, String strValue, String strProperty,
            String strPropertyVerify)
        {
            if (GetPropertyObect(strType, strValue, strProperty) != null)
            {
                return GetPropertyObect(strType.Trim(), strValue.Trim(), strProperty.Trim()).Equals(strPropertyVerify.Trim());
            }
            else
            {
                return false;
            }
        }

        public void ClickDropDown(String strType, String strValue, String conteudo)
        {
            var elemento = GetIWebElement(strType, strValue);

            SelectElement dropDrowSelect = new SelectElement(elemento);
            dropDrowSelect.SelectByText(conteudo.Trim());
        }

        public void ClickDropDownIndex(String strType, String strValue, int index)
        {
            var elemento = GetIWebElement(strType, strValue);

            SelectElement dropDrowSelect = new SelectElement(elemento);
            dropDrowSelect.SelectByIndex(index);
        }


        public void HoverLink(String strType, String strValue)
        {
            var elemento = GetIWebElement(strType, strValue);
            Actions builder = new Actions(Driver);
            builder.MoveToElement(elemento).Build().Perform();
        }


        public void ClickCheckBox(String strType, String strValue, Boolean isCheck)
        {
            var elemento = GetIWebElement(strType, strValue);
            var isElementIsCheck = elemento.Selected;

            if (!isCheck && isElementIsCheck)
            {
                elemento.SendKeys(Keys.Space);
            }
            else if (isCheck && !isElementIsCheck)
            {
                elemento.SendKeys(Keys.Space);
            }
        }


        public void ClickDropDownValue(String strType, String strValue, String strPropertyValue)
        {
            var elemento = GetIWebElement(strType, strValue);

            SelectElement dropDrowSelect = new SelectElement(elemento);
            dropDrowSelect.SelectByValue(strPropertyValue.Trim());
        }

        public String GetText(String strType, String strValue)
        {
            var elemento = GetIWebElement(strType, strValue);
            return elemento.Text.Trim();
        }


        public String GetPropertyObect(String strType, String strValue, String strProperty)
        {
            var htmlElemnet = GetIWebElement(strType, strValue);

            return htmlElemnet.GetProperty(strProperty).Trim();
        }

        public void ClearText(String strType, String strValue)
        {
            var elemento = GetIWebElement(strType, strValue);
            elemento.Clear();
        }

        [Obsolete]
        public void WaintForObject(String strType, String strValue, long timeout)
        {
            Thread.Sleep(1000);
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(timeout));
            if (strType.Equals(".id"))
            {

                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(strValue)));


            }
            else if (strType.Equals(".className"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName(strValue)));

            }
            else if (strType.Equals(".cssSelector"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(strValue)));

            }
            else if (strType.Equals(".linkText"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText(strValue)));

            }
            else if (strType.Equals(".name"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(strValue)));

            }
            else if (strType.Equals(".partialLinkText"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.PartialLinkText(strValue)));

            }
            else if (strType.Equals(".tagName"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName(strValue)));

            }
            else if (strType.Equals(".xPath"))
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(strValue)));

            }


        }




        public String ExecuteJavaScriptReturnString(String cmd)
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            string strJs = (String)js.ExecuteScript(cmd);
            PrintToConsole(cmd);
            return strJs.Trim();
        }


        public int ExecuteJavaScriptReturnInt(String cmd)
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            PrintToConsole(cmd);
            int intJs = (int)js.ExecuteScript(cmd);

            return intJs;
        }




        public void ExecuteJavaScript(String cmd)
        {


            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            PrintToConsole(cmd);
            js.ExecuteScript(cmd);



        }

        public void Screenshot()
        {
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            string dataAtual = DateTime.Now.ToString().Replace("/", "").Trim().Replace(":", "");
            ss.SaveAsFile(@"C:\Webdriver\" + dataAtual.Trim() + ".png", ScreenshotImageFormat.Png);

        }


        public void VerificationPointConditional(Boolean condicaoEsperada, Boolean condicaoAtual)
        {


            Screenshot();
            Assert.AreEqual(condicaoEsperada, condicaoAtual);
        }

        public void VerificationPointConditionalString(String condicaoEsperada, String condicaoAtual)
        {
            Thread.Sleep(1000);

            Screenshot();
            Assert.AreEqual(condicaoEsperada, condicaoAtual);
        }

        [Obsolete]
        public IWebElement GetIWebElement(String strType, String strValue)
        {
            var timeout = 30000; // in milliseconds


            WaintForObject(strType, strValue, timeout);
            if (strType.Equals(".id"))
            {
                return Driver.FindElement(By.Id(strValue.Trim()));

            }
            else if (strType.Equals(".className"))
            {
                return Driver.FindElement(By.ClassName(strValue.Trim()));

            }
            else if (strType.Equals(".cssSelector"))
            {
                return Driver.FindElement(By.CssSelector(strValue.Trim()));

            }
            else if (strType.Equals(".linkText"))
            {
                return Driver.FindElement(By.LinkText(strValue.Trim()));

            }
            else if (strType.Equals(".name"))
            {
                return Driver.FindElement(By.Name(strValue));

            }
            else if (strType.Equals(".partialLinkText"))
            {
                return Driver.FindElement(By.PartialLinkText(strValue));

            }
            else if (strType.Equals(".tagName"))
            {
                return Driver.FindElement(By.TagName(strValue));

            }
            else if (strType.Equals(".xPath"))
            {
                return Driver.FindElement(By.XPath(strValue));

            }

            return null;
        }


        public static void PrintToConsole(String strCmd)
        {
            Console.WriteLine(strCmd);
        }

        public void LoadURL(String url)
        {

            Driver.Navigate().GoToUrl(url);
        }

        public static void MaximizeBrowser()
        {
            Driver.Manage().Window.Maximize();
        }


        public static void CloseBrowser()
        {
            Driver.Close();
        }


        // Trigger down key
        public void TriggerDownKey()
        {
            var sim = new InputSimulator();
            sim.Keyboard
              .KeyPress(VirtualKeyCode.DOWN);
        }


        public void TriggerUpKey()
        {
            var sim = new InputSimulator();
            sim.Keyboard
              .KeyPress(VirtualKeyCode.DOWN);
        }


        public void TriggerUpKey(int amountTimes)
        {
            for (int i = 0; i < amountTimes; i++)
            {
                TriggerUpKey();
            }
        }


        public void TriggerDownKey(int amountTimes)
        {
            for (int i = 0; i < amountTimes; i++)
            {
                TriggerDownKey();
            }
        }

    }
}
