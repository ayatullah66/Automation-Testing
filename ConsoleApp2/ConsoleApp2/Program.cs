using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IWebDriver Driver = new FirefoxDriver(@"F:\Selenium needs");
            
            Driver.Url = "http://www.google.com";
            
            Driver.FindElement(By.XPath("//a[contains(text(),'Gmail')]")).Click();
            






        }
    }
}
