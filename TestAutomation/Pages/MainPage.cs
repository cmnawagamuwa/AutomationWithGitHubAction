using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.Pages
{
    internal class MainPage
    {
        public MainPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement NewMesssageBtn => Driver.FindElement(By.CssSelector("[data-testid='teamInbox-leftSide-actionBar-newMessage-button']"));

        public bool IsNewMessageBtnExist => NewMesssageBtn.Displayed;

        public IWebElement MobileMenuIcon => Driver.FindElement(By.ClassName("mobile__menu-icon"));

        public bool IsMobileMenuIconExist => MobileMenuIcon.Displayed;


        public void ClickTeamInbox()
        {
            Assert.That(IsMobileMenuIconExist, Is.True);
            MobileMenuIcon.Click();
            var TeamInboxTab = Driver.FindElement(By.LinkText("Team Inbox"));
            Assert.That(TeamInboxTab.Displayed, Is.True);
            TeamInboxTab.Click();
        }

        public IWebElement ContactsTab => Driver.FindElement(By.LinkText("Contacts"));

        public bool IsContactsTabExist => ContactsTab.Displayed;

        public void ClickContacts()
        {
            Assert.That(IsMobileMenuIconExist, Is.True);
            MobileMenuIcon.Click();
            var ContactsTab = Driver.FindElement(By.LinkText("Contacts"));
            Assert.That(ContactsTab.Displayed, Is.True);
            ContactsTab.Click();
            Task.Delay(2000).Wait();
        }

       
        public void ClickBroadcast()
        {
            Assert.That(IsMobileMenuIconExist, Is.True);
            MobileMenuIcon.Click();

            var BroadcastTab = Driver.FindElement(By.LinkText("Broadcast"));
            Assert.That(BroadcastTab.Displayed, Is.True);

            BroadcastTab.Click();
            Task.Delay(2000).Wait();
        }

        public void ClickAutomation()
        {
            Assert.That(IsMobileMenuIconExist, Is.True);
            MobileMenuIcon.Click();

            var AutomationTab = Driver.FindElement(By.LinkText("Automation"));
            Assert.That(AutomationTab.Displayed, Is.True);
            
            AutomationTab.Click();
            Task.Delay(2000).Wait();
        }


        public void ClickDashboard()
        {
            Assert.That(IsMobileMenuIconExist, Is.True);
            MobileMenuIcon.Click();

            var DashboardTab = Driver.FindElement(By.LinkText("Dashboard"));
            Assert.That(DashboardTab.Displayed, Is.True);

            DashboardTab.Click();
            Task.Delay(2000).Wait();
        }

        public IWebElement ProfileAvatarButton => Driver.FindElement(By.CssSelector("[aria-label='account of current user']"));
        public IWebElement SignoutBtn => Driver.FindElement(By.CssSelector("[data-testid='profileMenu-firstGroup-signOut-button']"));
        public IWebElement SignoutConfirmedBtn => Driver.FindElement(By.CssSelector("[data-testid='modals-confirmDialog-content-buttons-negative-button']"));

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
