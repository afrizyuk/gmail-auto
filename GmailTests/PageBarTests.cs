using NUnit.Framework;

namespace GmailTests
{
    [TestFixture]
    public class PageBarTests : BaseTests
    {
        [SetUp]
        public void Delete_All_Emails_If_They_Are_Present()
        {
            if (mailBox.UsePaginator().PageBarShows)
                mailBox.UseMenu().Select_Emails().Delete();
        }
        
        [Test]//CS_000
        public void PageBar_Doesnt_Show_With_Empty_Inbox()
        {
            Assert.IsFalse(mailBox.UsePaginator().PageBarShows);
        }

        [Test]  //CS_001
        public void Buttons_Not_Active_When_Only_One_Email_In_Inbox()
        {
            mailBox.SendEmails(1)
                .UseMenu().Refresh();
            
            Assert.IsTrue(mailBox.UsePaginator().NextButtonDisabled);
            Assert.IsTrue(mailBox.UsePaginator().PrevButtonDisabled);
        }
       
    }
}
