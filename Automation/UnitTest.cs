using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation
{
    public class Tests
    {
        public IWebDriver Driver;



        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            Driver = new ChromeDriver(chromeOptions);
            //New comment added

        }

        /// <summary>
        /// First Test method
        /// </summary>
        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://live-102914.watiapp.io/login");
            Assert.AreEqual("WATI - WhatsApp Team Inbox", Driver.Title);
        }
    }
}