
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static TastCaseN11.Constants.ConstantMainPage;
using OpenQA.Selenium.Support.UI;

namespace TastCaseN11.Page
{
    public class SearchPage : Base.BasePage
    {
        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void Search(String searchData)
        {
            KeySend(SEARCH, searchData);
            Click(SEARCHBUTTON);

        }
        public void ChangePageBtn()
        {
            HoverElement(PRODUCTLIST);
            Click(PRODUCTLIST);

        }


    }
}
