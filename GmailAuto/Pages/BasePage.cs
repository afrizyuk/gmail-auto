using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace GmailAuto.Pages
{
    public abstract class BasePage
    {
        internal IWebDriver Driver{get { return Browser.Driver(); }}
        protected static MailBoxPage defaultPage = new MailBoxPage();

        protected string login = "afrizyuk.tester@gmail.com";
        protected string pass = "SoftwareTester";


        protected BasePage()
        {
            PageFactory.InitElements(Driver, this);
        }

        public MailBoxPage EndUse()
        {
            return defaultPage;
        }

    }
}