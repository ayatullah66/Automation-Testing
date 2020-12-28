using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp3
{

    [TestFixture]
    public class Google_search
    {
        IWebDriver Driver ;

        [SetUp]
        public void Intialize()
        {
            Driver = new FirefoxDriver(@"F:\Selenium needs");
            Driver.Url = "http://www.google.com";
        }

        [Test]
        public void Search_for_numbers()
        {
            Driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5*1000));
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("1000000");
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
            //Assert.Greater(Driver.FindElements(By.ClassName("LC20lb")).Count,16);
            Assert.IsTrue(Driver.FindElements(By.ClassName("LC20lb")).Count.Equals(0));
        }

        [Test]
        public void Search_for_letters()
        {

            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("aya hassan");
        }
        
        [TearDown]
        public void Close()
        {
            Driver.Close();
        }

       
    }
}
