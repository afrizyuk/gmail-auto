using System.Threading;
using GmailAuto;
using GmailAuto.Pages;
using NUnit.Framework;


namespace GmailTests
{
    public class BaseTests
    {
        protected MailBoxPage mailBox;
        

        [TestFixtureSetUp]
        public void Init()
        {
            mailBox = new LoginPage().LogIn();
        }

        [TestFixtureTearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            if (mailBox.UsePaginator().PageBarShows)
            {
                mailBox.UseMenu().Select_Emails();
                mailBox.UseMenu().Delete();
            }

            Browser.Close();
        }
        
    }
}
