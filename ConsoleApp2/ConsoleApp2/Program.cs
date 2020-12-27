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

            //open gmail 
            //Driver.FindElement(By.XPath("//a[contains(text(),'Gmail')]")).Click();
            
            //Select Element from array list
            /*
            Driver.FindElement(By.Name("q")).SendKeys("ID");
            Driver.FindElement(By.ClassName("gLFyf")).SendKeys("ClassName");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));    // explicit wait for only needed load process
            Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("LC20lb")));

            Driver.FindElements(By.ClassName("LC20lb"))[0].Click();
            */
            //Search for image on google
            Driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
            Driver.FindElement(By.XPath("//a[contains(text(),'صور')]")).Click();   //click on image button
            Driver.FindElement(By.XPath("//span[@class='BwoPOe']")).Click();     //click on camera icon
            Driver.FindElement(By.Id("awyMjb")).SendKeys("F:\\image\\index.jpg");   // send image path

            







        }
    }
}
