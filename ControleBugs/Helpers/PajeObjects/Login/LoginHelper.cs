using ControleBugs.Util;
using OpenQA.Selenium;

namespace ControleBugs.Helpers
{
    public class LoginHelper : TelaHelper
    {

        public static void LoginAPP()
        {
            var usuario = ReadAppConfig.ReadSetting("userWeb");
            var password = ReadAppConfig.ReadSetting("passWordWeb");

            OpenApp();
            Sleep(2);


            SetText(".id", "user_email",usuario);

            SetText(".id", "user_password", password);
            ClickObjet(".name", "commit");



        }

        public static void OpenApp()
        {
            var url = ReadAppConfig.ReadSetting("urlTest");
            Driver.Navigate().GoToUrl(url);

            
        }




    }
}
