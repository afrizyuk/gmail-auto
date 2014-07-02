using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using GmailAuto.Pages;

namespace GmailTests
{
    [TestFixture]
    public class MenuTests : BaseTests
    {
        [Test]
        public void User_Can_Select_Emails()
        {
            mailBox.UseMenu().Select_Emails();
           // mailBox.UseMenu().Delete();
        }
    }
}
