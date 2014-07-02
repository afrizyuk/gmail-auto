using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Pages
{
    public class LoginPage : BasePage
    {
        //locators

        [FindsBy(How = How.Id, Using = "Email")] 
        private IWebElement userName = null;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement password = null;

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement logInButton = null;

        public LoginPage()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://gmail.com");

        }
        
        public MailBoxPage LogIn()
        {
            userName.SendKeys(login);
            password.SendKeys(pass);
            logInButton.Click();
            return defaultPage;

        }
    }
}
