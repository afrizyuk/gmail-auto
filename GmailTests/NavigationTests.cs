using System.Threading;
using GmailAuto.Helpers;
using NUnit.Framework;

namespace GmailTests
{
    [TestFixture]
    public class NavigationTests : BaseTests
    {
        [Test]
        public void User_Can_Navigate()
        {
            mailBox.UseNavigator().GoTo(To.Starred);
            Thread.Sleep(3000);
            mailBox.UseNavigator().GoTo(To.Sent);
            Thread.Sleep(3000);
            mailBox.UseNavigator().GoTo(To.Drafts);
            Thread.Sleep(3000);
            mailBox.UseNavigator().GoTo(To.More);
            Thread.Sleep(3000);
            mailBox.UseNavigator().GoTo(To.Incoming);

        }
    }
}
