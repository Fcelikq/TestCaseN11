
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static TastCaseN11.Constants.ConstantMainPage;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TastCaseN11.Page
{
    public class OutputMessages : Base.BasePage
    {

        public OutputMessages(IWebDriver webDriver) : base(webDriver)
        {
        }


        public void TestPageLoad(string url)
        {
            Assert.AreEqual("https://www.n11.com/", url, "Sayfa Goruntulendi");

        }
        public void TestChangePage(string url)
        {

            Assert.AreEqual("https://www.n11.com/arama?q=samsung&pg=2", url, "2. Sayfadasiniz");
        }



    }
}
