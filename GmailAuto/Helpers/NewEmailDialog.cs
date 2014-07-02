using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class NewEmailDialog
    {
        public SendEmailCommand SendEmailTo(string recipientAddress)
        {
            return new SendEmailCommand(recipientAddress);
        }
    }

    public class SendEmailCommand : BasePage
    {
        public SendEmailCommand(string recipientAddress)
        {
            AddressField.WaitUntilVisible().SendKeys(recipientAddress);
        }

        public SendEmailCommand WithTitle(string title)
        {
            TitleField.SendKeys(title);
            return this;
        }

        public SendEmailCommand WithBody(string body)
        {
            var bodyFrame = Driver
               .FindElement(By.CssSelector(".Am.Al.editable"))
               .FindElement(By.TagName("iframe"));

            
            Driver.SwitchTo().Frame(bodyFrame);
            Driver.SwitchTo().ActiveElement().SendKeys(body);
            Driver.SwitchTo().DefaultContent();
            
            return this;
        }

        public void Send()
        {
           SendButton.Click();
        }

        //Locators
        [FindsBy(How = How.CssSelector, Using = ".vO")] 
        private IWebElement AddressField = null;

        [FindsBy(How = How.CssSelector, Using = ".aoT")] 
        private IWebElement TitleField = null;

        [FindsBy(How = How.CssSelector, Using = ".T-I.J-J5-Ji.aoO.T-I-atl.L3")] 
        private IWebElement SendButton = null;

    }
}
