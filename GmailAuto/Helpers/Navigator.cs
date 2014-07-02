using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class Navigator : BasePage
    {
        // Locators
        [FindsBy(How = How.CssSelector, Using = ".T-I.J-J5-Ji.T-I-KE.L3")]
        private IWebElement WriteAnEmailButton = null;
        
        [FindsBy(How = How.CssSelector, Using = "div.TK * a[href*=inbox]")] 
        private IWebElement InboxLink = null;
        
        [FindsBy(How = How.CssSelector, Using = "div.TK * a[href*=starred]")] 
        private IWebElement StarredLink = null;
        
        [FindsBy(How = How.CssSelector, Using = "div.TK * a[href*=sent]")] 
        private IWebElement SentLink = null;

        [FindsBy(How = How.CssSelector, Using = "div.TK * a[href*=drafts]")]
        private IWebElement DraftsLink = null;

        [FindsBy(How = How.CssSelector, Using = "span.CJ")] 
        private IWebElement MoreLink = null;



        // Methods
        public Navigator GoTo(To to)
        {
            switch (to)
            {
                case To.Incoming:
                    InboxLink.WaitUntilVisible().Click();
                    break;
                case To.Starred:
                    StarredLink.WaitUntilVisible().Click();
                    break;
                case To.Sent:
                    SentLink.Click();
                    break;
                case To.Drafts:
                    DraftsLink.Click();
                    break;
                case To.More:
                    MoreLink.Click();
                    break;
            }

            return this;
        }

        public NewEmailDialog WriteNewEmail()
        {
            WriteAnEmailButton.WaitUntilVisible().Click();
            return new NewEmailDialog();
        }
    }

    public enum To
    {
        Incoming
       ,Starred
        ,Sent
        ,Drafts
        ,More
    }
}
