using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class Email : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "h2.hP")]
        private IWebElement Title_Label = null;

        //[FindsBy(How = How.CssSelector, Using = "div.ii div[dir=ltr]")]
        //private IWebElement Body = null;

        public string Title
        {
            get { return Title_Label.WaitUntilVisible().Text; }
        }
    }
}
