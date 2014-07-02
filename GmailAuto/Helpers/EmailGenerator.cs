using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailAuto.Helpers
{
    public class EmailGenerator
    {
        private Random random = new Random();

        private static string[] titleWords = 
        {
            "warning", "represent", "glad", "we", "notebook", "microsoft", "internet"
            , "skydive", "google", "burton", "selenium"
        };

        private static string[] bodyWords =
        {
            "m'cdonalds", "firefox", "opera", "sony", "playstation", "uncharted", "collosus"
            , "destiny", "upiter", "call", "duty", "contra", "striky", "onion", "potato"
            , "police", "denver", "ciklum", "luxoft", "maintain"
        };

        public string GetTitle()
        {
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                str += " " + titleWords[random.Next(0, titleWords.Length)];
            }

            return str.TrimStart();
        }

        public string GetBody()
        {
            string str = "";
            for (int i = 0; i < 12; i++)
            {
                str += " " + bodyWords[random.Next(0, titleWords.Length)];
            }

            return str;

        }
        
    }
}
