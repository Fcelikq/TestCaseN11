using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace TastCaseN11.Constants
{
    static class ConstantMainPage
    {
        public static By SIGNBUTTON = By.ClassName("btnSignIn");
        public static By USERNAME = By.Id("email");
        public static By PASSWORD = By.Id("password");
        public static By LOGINBUTTON = By.Id("loginButton");
        public static By SEARCH = By.Id("searchData");
        public static By SEARCHBUTTON = By.ClassName("icon");
        public static By PRODUCTLIST = By.XPath("//div[@class='pagination']/a[2]");
        public static By FINDPRODUCT = By.XPath("//div[@id='view']/ul/li[3]/div/div[1]/span");
        public static By HOVERMENU = By.ClassName("myAccount");
        public static By FAVORITESBUTTON = By.XPath("//div[@class='hOpenMenuContent']/a[2]");
        public static By ALLFAVORITES = By.XPath("//div[@class='listItemWrap']/a[1]");
        public static By DELETEFAVORITES = By.XPath("//div[@id='view']/ul/li[1]/div/div[3]/span");
        public static By CLOSECONFIRM = By.ClassName("btnBlack");


    }
}
