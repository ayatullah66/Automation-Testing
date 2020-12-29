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

        [Test,Order(3)]
        public void Search_for_numbers()
        {
            Driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5*1000));
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("1000000");
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
        }

        [Test,Order(1)]
        public void Search_for_letters()
        {
            Driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(60 * 1000));
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Zafer Al Abdeen");
            Driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(Keys.Enter);
            Assert.Greater(Driver.FindElements(By.XPath("//span")).Count, 13);
            Assert.IsTrue(Driver.FindElements(By.XPath("//span")).Count.Equals(14));
        }

        [Test,Order(2)]
        public void Search_for_image()
        {
            Driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(60 * 1000));
            Driver.FindElement(By.XPath("//a[contains(text(),'صور')]")).Click();   
            Driver.FindElement(By.XPath("//span[@class='BwoPOe']")).Click();     
            Driver.FindElement(By.Id("awyMjb")).SendKeys("F:\\image\\index.jpg");
        }


        [TearDown]
        public void Close()
        {
            Driver.Close();
        }

       
    }
}
