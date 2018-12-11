using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinTestingProg
{
    class Program
    {
        IWebDriver driver;

        static void Main(string[] args)
        {
            var run = new Program();
            run.involeBrowser();

        }
        public void involeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.google.com/");

        }
        [Test]
        public void TestTrue()
        {
            Assert.AreEqual(9, 9);

        }

       // [Test]
        public void TestFalse()
        {
            Assert.AreEqual(9, 19);

        }
    }

}
