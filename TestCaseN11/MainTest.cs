using OpenQA.Selenium;
using TastCaseN11.Page;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TastCaseN11.Test
{
    class MainTest
    {
        static IWebDriver driver;
        LoginPage loginPage;
        SearchPage searchPage;
        FindProductPage findProductPage;
        FavoritesPage favoritesPage;
        OutputMessages outputMessages;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            loginPage = new LoginPage(driver);
            searchPage = new SearchPage(driver);
            findProductPage = new FindProductPage(driver);
            favoritesPage = new FavoritesPage(driver);
            outputMessages = new OutputMessages(driver);


            driver.Navigate().GoToUrl("https://www.n11.com/");
        }


        [Test]
        public void TestCase()
        {
            //Sayfa Goruntulenme testi
            outputMessages.TestPageLoad(driver.Url);

            //giris
            loginPage.Login("kkazuya333@gmail.com", "deneme123");

            //arama 
            searchPage.Search("samsung");


            //sonuc bulundugunun testi
            try
            {
                driver.FindElement(By.Id("view"));
                Console.WriteLine("Urun bulundu");
            }
            catch (Exception)
            {
                Console.WriteLine("urun bulunamadi");
            }
            Console.Read();


            //Sayfa degistir
            searchPage.ChangePageBtn();

            //sayfanin degistiginin testi
            outputMessages.TestChangePage(driver.Url);

            //urunu favorilere ekle
            findProductPage.FindProduct();

            //urunun Data id yakala
            var element1 = findProductPage.elementID();

            //favorilere git
            favoritesPage.GoFavorites();

            //tum favorileri goster
            favoritesPage.ShowAllFavorites();

            //favorideki urunun Data id yakala
            var element2 = favoritesPage.FavoritesElementID();

            //Data id  karsilastir 
            Assert.AreEqual(element1, element2, "Urun izlemeye alindi");


            //favori urunu sil
            favoritesPage.DeleteFavorites();

            //acilan confirm i kapat
            favoritesPage.CloseConfirm();

            //favori listesini kontrol et
            WaitSeconds(3);
            try
            {
                var deleteTest = driver.FindElement(By.ClassName("emptyWatchList"));
                Console.WriteLine("Urun silindi");
            }
            catch (Exception)
            {
                Console.WriteLine("Urun silinmedi");
            }
            Console.Read();
        }
        public void WaitSeconds(int second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }


        [Test]
        public void Testlogin()
        {
            loginPage.Login("kkazuya333@gmail.com", "deneme123");
        }
        [Test]
        public void TestSearch()
        {
            searchPage.Search("samsung");

        }
        [Test]
        public void TestFindProduct()
        {
            loginPage.Login("kkazuya333@gmail.com", "deneme123");
            searchPage.Search("samsung");
            findProductPage.FindProduct();
        }
        [Test]
        public void TestFavorites()
        {
            loginPage.Login("kkazuya333@gmail.com", "deneme123");
            favoritesPage.GoFavorites();
            favoritesPage.ShowAllFavorites();

        }
        [Test]
        public void TestDeleteFavorite()
        {
            loginPage.Login("kkazuya333@gmail.com", "deneme123");
            favoritesPage.GoFavorites();
            favoritesPage.ShowAllFavorites();
            favoritesPage.DeleteFavorites();

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}
