using NUnit.Framework;

namespace GmailTests
{
    [TestFixture]
    public class NewFeaturesTests : BaseTests
    {
        [Test]
        public void New_Test()
        {
            mailBox.SendEmails(5).UseMenu().Refresh().Select_Emails().Delete();
        }
    }
}
