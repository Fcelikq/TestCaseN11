
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static TastCaseN11.Constants.ConstantMainPage;
using OpenQA.Selenium.Support.UI;

namespace TastCaseN11.Page
{
    public class FindProductPage : Base.BasePage
    {
        public FindProductPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void FindProduct()
        {
            HoverElement(FINDPRODUCT);

            Click(FINDPRODUCT);
        }
        public string elementID()
        {
            var element = FindElement(By.XPath("//div[@id='view']/ul/li[3]/div/div[1]/a[1]"));
            var elementId = element.GetAttribute("data-id");
            return elementId;

        }


    }
}
