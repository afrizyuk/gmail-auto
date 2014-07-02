using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GmailAuto
{
    public static class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Driver()
        {
            driver = driver ?? new FirefoxDriver();
            return driver;
        }

        public static void Close()
        {
            Thread.Sleep(3000);
            if(driver != null) driver.Quit();
        }

        public static string CurrentUrl
        {
            get {return driver.Url; }
        }

        static readonly Finalizer finalizer = new Finalizer();
        sealed class Finalizer
        {
            ~Finalizer()
            {
                Close();
            }
        }
    }
}
