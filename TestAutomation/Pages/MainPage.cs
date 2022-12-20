using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation
{
    internal class MainPage : WebDriver
    { 
        public IWebElement ProfileAvatarButton => Driver.FindElement(By.CssSelector("[aria-label='account of current user']"));

        public IWebElement SignoutBtn => Driver.FindElement(By.CssSelector("[data-testid='profileMenu-firstGroup-signOut-button']"));

        public IWebElement SignoutConfirmedBtn => Driver.FindElement(By.CssSelector("[data-testid='modals-confirmDialog-content-buttons-negative-button']"));

        public void VerifyLogin()
        {

            Task.Delay(3000).Wait();
            var messageButton = Driver.FindElement(By.XPath("//span[normalize-space()='New Message']"));
            Assert.That(messageButton, Is.True);
        }       


        public void checkContacts()
        {
            var ContactsTab = Driver.FindElement(By.LinkText("Contacts"));
            Assert.That(ContactsTab.Displayed, Is.True);
        }

       
        public void ClickBroadcast()
        {     
            var BroadcastTab = Driver.FindElement(By.LinkText("Broadcast"));
            Assert.That(BroadcastTab.Displayed, Is.True);

        }

        public void CheckAutomation()
        {           
            var AutomationTab = Driver.FindElement(By.LinkText("Automation"));
            Assert.That(AutomationTab.Displayed, Is.True);
        }

        public void SignOut()
        { 
            ProfileAvatarButton.Click();
            Task.Delay(1000).Wait();
            SignoutBtn.Click();
            Task.Delay(1000).Wait();
            SignoutConfirmedBtn.Click();
            Task.Delay(1000).Wait();
        }
    }
}
