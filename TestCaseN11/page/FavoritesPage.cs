
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static TastCaseN11.Constants.ConstantMainPage;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TastCaseN11.Page
{
    public class FavoritesPage : Base.BasePage
    {
        public FavoritesPage(IWebDriver webDriver) : base(webDriver)
        {
        }


        public void GoFavorites()
        {
            HoverElement(HOVERMENU);
            Click(FAVORITESBUTTON);

        }
        public void ShowAllFavorites()
        {
            Click(ALLFAVORITES);

        }

        public string FavoritesElementID()
        {
            var element = FindElement(By.XPath("//div[@id='view']/ul/li[1]/div/div[1]/a[1]"));
            var elementId = element.GetAttribute("data-id");
            return elementId;

        }
        public void DeleteFavorites()
        {
            Click(DELETEFAVORITES);
        }
        public void CloseConfirm()
        {
            HoverElement(CLOSECONFIRM);
            Click(CLOSECONFIRM);
        }



    }
}
