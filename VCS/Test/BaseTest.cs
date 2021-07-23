using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS.Test
{
    public class BaseTest
    {
 
        public static IWebDriver driver;
        public static SebPage _sebPage;
        

        [OneTimeSetUp]
        public static void SetUp()
        {
            _sebPage = new SebPage(driver);
        }

        [TearDown]
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            // driver.Quit(); 
        }
    }
}
    

