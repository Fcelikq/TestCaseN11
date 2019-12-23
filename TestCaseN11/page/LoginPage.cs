using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static TastCaseN11.Constants.ConstantMainPage;

namespace TastCaseN11.Page
{
    public class LoginPage : Base.BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void WaitSeconds(int second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }
        public void Login(String username, String password)
        {

            Click(SIGNBUTTON);
            WaitSeconds(2);
            KeySend((USERNAME), (username));
            KeySend((PASSWORD), (password));
            Click(LOGINBUTTON);
        }


    }
}
