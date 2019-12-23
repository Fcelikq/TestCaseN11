using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace TastCaseN11.Base

{
    public class BasePage
    {

        IWebDriver driver;
        WebDriverWait wait;
        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

        }
        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }
        public void KeySend(By by, String text)
        {
            FindElement(by).SendKeys(text);
        }
        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public void HoverElement(By by)
        {
            IWebElement element;
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
