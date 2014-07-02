using System.Threading;
using GmailAuto.core;
using GmailAuto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailAuto.Helpers
{
    public class Menu : BasePage
    {
        //Locators

        [FindsBy(How = How.CssSelector, Using = "div.Cq.aqL span.T-Jo")] 
        private IWebElement EmailsSelector_CheckBox = null;

        [FindsBy(How = How.CssSelector, Using = "div.Cq.aqL div.G-asx")]
        private IWebElement SelectionType_Button = null;

        [FindsBy(How = How.CssSelector, Using = "div.SK.AX div[selector=all]")]
        private IWebElement SelectionType_Menu_All = null;

        [FindsBy(How = How.CssSelector, Using = "div.Cq.aqL div.G-Ni:nth-of-type(4) div.T-I")]
        private IWebElement Refresh_Button = null;

        [FindsBy(How = How.CssSelector, Using = "div.Cq.aqL div.G-Ni:nth-of-type(2) div.T-I:nth-of-type(3)")]
        private IWebElement Delete_Button = null;

        [FindsBy(How = How.CssSelector, Using = "div.Kj-JD-Jl button[name=ok]")] 
        private IWebElement AcceptDelete_Button = null;

        [FindsBy(How = How.CssSelector, Using = "div.ya.yb span.x8")]
        private IWebElement SelectAllEmails_Link = null;

        

        public Menu Select_Emails()
        {
            EmailsSelector_CheckBox.WaitUntilVisible().Click();
            if(defaultPage.UsePaginator().Emails > 50)
                SelectAllEmails_Link.WaitUntilVisible().Click();

            return this;
        }

        public Menu Select_Emails(SelectionType selectionType)
        {
            SelectionType_Button.WaitUntilVisible().Click();
            

            switch (selectionType)
            {
                case SelectionType.All:
                    SelectionType_Menu_All.Click();
                    break;
                case SelectionType.None:
                    //SelectionType_MenuNone.Click();
                    break;
                case SelectionType.Read:
                    //SelectionType_MenuNone.Click();
                    break;
                case SelectionType.Unread:
                    //SelectionType_MenuNone.Click();
                    break;
                case SelectionType.Starred:
                    //SelectionType_MenuNone.Click();
                    break;
            }

            return this;
        }

        public Menu Refresh()
        {
            Refresh_Button.WaitUntilVisible().Click();
            Thread.Sleep(1000);
            return this;
        }

        public Menu Delete()
        {
            var emails = defaultPage.UsePaginator().Emails;
            Delete_Button.WaitUntilVisible().Click();
            if(emails > 50)
                AcceptDelete_Button.WaitUntilVisible().Click();

            return this;
        }
    }

    public enum SelectionType
    {
         All
        ,None
        ,Read
        ,Unread
        ,Starred
        ,Unstarred
    }
}
