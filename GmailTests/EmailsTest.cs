using System.Globalization;
using GmailAuto;
using GmailAuto.Helpers;
using NUnit.Framework;

namespace GmailTests
{
    [TestFixture]
    public class EmailsTest : BaseTests
    {
        [Test]
        public void User_Can_Send_Email() 
        {
            var emGen = new EmailGenerator();
            var title = emGen.GetTitle();
            var body = emGen.GetBody();


            var newEmail = mailBox.UseNavigator().WriteNewEmail();
            
            newEmail.SendEmailTo("afrizyuk.tester@gmail.com")
                .WithTitle(title)
                .WithBody(body)
                .Send();
            
            var email = mailBox.
                UseMenu().Refresh().EndUse()
                .UseEmails().OpenFirstUnreadEmail();
            
            Assert.AreEqual(email.Title, title, "Title doesn't match.");

        }
    }
}
