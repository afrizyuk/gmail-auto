using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class Emails : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = ".F.cf.zt")]
        private IWebElement _tableReference = null;

        [FindsBy(How = How.CssSelector, Using = "table.F.cf.zt tr.zA")] 
        private IList<IWebElement> EmailsCollection = null;


        private ReadOnlyCollection<IWebElement> GetEmails
        {
            get { return _tableReference.WaitUntilVisible().FindElements(By.CssSelector(".zA")); }
        }

        private ReadOnlyCollection<IWebElement> GetUnreadEmails
        {
            get { return _tableReference.WaitUntilVisible().FindElements(By.CssSelector(".zE")); }
        }
        
        public int EmailsAtPage
        {
            get { return GetEmails.Count; }
        }

        public int UnreadEmailsAtPage
        {
            get { return GetUnreadEmails.Count; }
        }

        public Email OpenFirstUnreadEmail()
        {
            GetUnreadEmails[0].Click();
            return new Email();
        }

        public int Count
        {
            get { return EmailsCollection.Count; }
        }

    }
}
