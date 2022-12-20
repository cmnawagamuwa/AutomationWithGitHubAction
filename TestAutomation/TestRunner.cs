using System;
namespace TestAutomation
{
	public class TestRunner : WebDriver
    {
        readonly LoginPage loginPage;
        readonly MainPage mainPage;

        public TestRunner()
        {
            loginPage = new LoginPage();
            mainPage = new MainPage();
        }        


        #region Navigate to the login page

        [Test]
        public void NavigateToLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [Test]
        public void IsLoginPage()
        {
            loginPage.IsThisLoginPage();
        }


        #endregion

        #region Login to the system

        [Test]
        public void LoginToTheSystem()
        {
            loginPage.Login(Username, Password);
        }

        [Test]
        public void VerifyTheLogin()
        {
            mainPage.VerifyLogin();
        }

        [Test]
        public void CheckContactsIsThere()
        {
            mainPage.checkContacts();
        }

        [Test]
        public void CheckBroadcastIsThere()
        {
            mainPage.ClickBroadcast();
        }

        [Test]
        public void CheckBAutomationIsThere()
        {
            mainPage.CheckAutomation();
        }

        #endregion


        //This reagions test cases should be the last couple of test cases. 
        #region Sign out check

        
        [Test]
        public void Signout()
        {
            mainPage.SignOut();
        }

        [Test]
        public void VerifySignout()
        {
            loginPage.IsThisLoginPage();
        }

        #endregion




        #region Exit from the driver

        [TearDown]
        public void TearDown() => Driver.Quit();

        #endregion
    }
}

