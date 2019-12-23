
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static TastCaseN11.Constants.ConstantMainPage;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TastCaseN11.Page
{
    public class ConfirmPage : Base.BasePage
    {
        public ConfirmPage(IWebDriver webDriver) : base(webDriver)
        {
        }


        public void CloseConfirm()
        {

            HoverElement(CLOSECONFIRM);
            Click(CLOSECONFIRM);
        }


    }
}
