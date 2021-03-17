using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://tanlaktanya.taszi.hu";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("Belépés")).Click();
            driver.FindElement(By.Id("username")).SendKeys("seleniumtest");
            driver.FindElement(By.Id("password")).SendKeys("a1234567"+Keys.Enter);
            driver.FindElement(By.LinkText("Programozás")).Click();
            driver.FindElement(By.LinkText("Szoftverfejlesztő (14d13b)")).Click();




            Console.ReadKey();
        }
    }
}
