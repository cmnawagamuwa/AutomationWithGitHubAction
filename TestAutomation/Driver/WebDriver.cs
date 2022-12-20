using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestAutomation
{
	public class WebDriver : Configurations
    {
        public IWebDriver Driver;

        public WebDriver()
		{
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            chromeOptions.AddArguments("--start-maximized");
            Driver = new ChromeDriver(chromeOptions);
        }
	}
}