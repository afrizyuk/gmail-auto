using System.Threading;
using GmailAuto.Helpers;

namespace GmailAuto.Pages
{
    public class MailBoxPage : BasePage
    {
        public bool IsAt
        {
            get
            {
                Thread.Sleep(3000);
                return Browser.CurrentUrl.Contains("inbox");
            }
        }

        //  Methods

        public Emails UseEmails()
        {
            return emails;
        }

        public Paginator UsePaginator()
        {
            return pageBar;
        }

        public Menu UseMenu()
        {
            return menu;
        }

        public Navigator UseNavigator()
        {
            return navigator;
        }

        public MailBoxPage SendEmails(int countEmailsToSend)
        {
            var generator = new EmailGenerator();
            for (int counter = 1; counter <= countEmailsToSend; counter++)
            {
                navigator.WriteNewEmail()
                    .SendEmailTo("afrizyuk.tester@gmail.com")
                    .WithTitle(generator.GetTitle())
                    .WithBody(generator.GetBody())
                    .Send();
            }

            return this;
        }
        
        //Elements Instances
        private Emails emails = new Emails();
        private Paginator pageBar = new Paginator();
        private Navigator navigator = new Navigator();
        private Menu menu = new Menu();
    }
}