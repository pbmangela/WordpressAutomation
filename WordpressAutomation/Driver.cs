using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace WordpressAutomation
{
   public class Driver
    {

        public static IWebDriver Instance { get; set; }
        public static void Initialized ()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));


        }


        public static void Close()
        {

            Instance.Close();

        }

    }
}
