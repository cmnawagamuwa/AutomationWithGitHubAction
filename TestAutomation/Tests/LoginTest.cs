using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestAutomation.Pages;

namespace TestAutomation.Tests
{
    internal class LoginTest
    {
        IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            webDriver = new ChromeDriver(chromeOptions);

            webDriver.Navigate().GoToUrl("https://wati-demo15.clare.ai/login");
           
        }

        [Test]
        public void Login()
        {
            LoginPage loginPage = new(webDriver);
            loginPage.Login("vernal@clare.ai", "Test1234!");

            MainPage mainPage = new(webDriver);
            Assert.That(mainPage.IsNewMessageBtnExist, Is.True);

            Task.Delay(3000).Wait();

            mainPage.ClickContacts();

            mainPage.ClickBroadcast();

            mainPage.ClickAutomation();

            mainPage.ClickDashboard();

            mainPage.SignOut();

            Assert.That(loginPage.IsBtnLoginExist, Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
