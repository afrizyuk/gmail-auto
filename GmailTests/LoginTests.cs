using NUnit.Framework;

namespace GmailTests
{
    [TestFixture]
    public class LoginTests:BaseTests
    {
        [Test]
        public void User_Can_LogIn()
        {
            Assert.IsTrue(mailBox.IsAt, "Can't Log In");
        }
        
    }
}
