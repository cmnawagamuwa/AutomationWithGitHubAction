﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestAutomation.Pages
{
    internal class LoginPage
    {
        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement TxtEmail => Driver.FindElement(By.Name("email"));

        public IWebElement TxtPassword => Driver.FindElement(By.Name("password"));

        public IWebElement BtnLogin => Driver.FindElement(By.XPath("//button[text()='Login']"));

        public bool IsBtnLoginExist => BtnLogin.Displayed;

        public void ClickLogin() => BtnLogin.Click();

        public void Login(string email, string password)
        {
            TxtEmail.SendKeys(email);
            TxtPassword.SendKeys(password);
            ClickLogin();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("[data-testid='teamInbox-leftSide-actionBar-newMessage-button']")));
        }
    }
}
