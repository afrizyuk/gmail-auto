using System;
using System.Threading;
using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class Paginator : BasePage
    {
        // Locators
        [FindsBy(How = How.CssSelector, Using = "span.Di div:nth-of-type(2)")] 
        private IWebElement PrevEmails_Button = null;

        [FindsBy(How = How.CssSelector, Using = "span.Di div:nth-of-type(3)")]
        private IWebElement NextEmails_Button = null;

        [FindsBy(How = How.CssSelector, Using = "div.ar5.J-J5-Ji>.Di")] 
        private IWebElement PageBar = null;


        [FindsBy(How = How.CssSelector, Using = "span.Di b:nth-of-type(1)")]
        private IWebElement FromEmail_Label = null;

        [FindsBy(How = How.CssSelector, Using = "span.Di b:nth-of-type(2)")]
        private IWebElement ToEmail_Label = null;
            
        [FindsBy(How = How.CssSelector, Using = "span.Di b:nth-of-type(3)")]
        private IWebElement Emails_Label = null;

        /// <summary>
        /// Opens next page with emails
        /// </summary>
        public Paginator GoNextEmails()
        {
            NextEmails_Button.WaitUntilVisible().Click();
            Thread.Sleep(1000);
            return this;
        }

        public Paginator GoPreviousEmails()
        {
            PrevEmails_Button.WaitUntilVisible().Click();
            Thread.Sleep(1000);
            return this;
        }

        public int Emails
        {
            get { return Convert.ToInt32(Emails_Label.WaitUntilVisible().Text); }
        }

        public int FromEmail
        {
            get { return Convert.ToInt32(FromEmail_Label.WaitUntilVisible().Text); }
        }

        public int ToEmail
        {
            get { return Convert.ToInt32(ToEmail_Label.WaitUntilVisible().Text); }
        }

        public bool PageBarShows
        {
            get { return !(PageBar.WaitUntilVisible().Text.Equals(" ")); }
        }

        public bool NextButtonDisabled
        {
            get { return (NextEmails_Button.WaitUntilVisible().GetAttribute("aria-disabled") != null); }
        }

        public bool PrevButtonDisabled
        {
            get { return (PrevEmails_Button.WaitUntilVisible().GetAttribute("aria-disabled") != null); }
        }
    }
}
