using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            //IList<IWebElement> szekcio = driver.FindElements(By.XPath("/html/body/div[2]/div/div[4]/div/div/div[1]/div/div/div/ul/li[2]/div[3]"));
            //IList<IWebElement> szekcio = driver.FindElements(By.XPath("/html/body/div[2]/div/div[4]/div/div/div[1]/div/div/div/ul/li[2]"));
            driver.FindElement(By.XPath("//span[contains(.,'Akna pozíció generáló osztály feladat feltöltése (.zip-ben)')]")).Click();


            //for (int i = 0; i < szekcio.Count; i++)
            //{
            //    Console.WriteLine(szekcio[i].Text);
            //}

            Thread.Sleep(5000);

            driver.Close();




            Console.ReadKey();
        }
    }
}
