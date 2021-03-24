using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium;
using System;

namespace WpfOsztasTest
{
    public class Tests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        private const string WpfProgramId = @"G:\c#_uj_projektek\14d_2000\WpfAutoTest\WpfAutoTest\bin\Debug\WpfAutoTest.exe";

        private const string WpfProgramPath = @"G:\c#_uj_projektek\14d_2000\WpfAutoTest\WpfAutoTest\bin\Debug\";

        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public static void Setup()
        {
            if (driver==null)
            {
                var appiumoptions = new AppiumOptions();
                appiumoptions.AddAdditionalCapability("app",WpfProgramId);
                appiumoptions.AddAdditionalCapability("deviceName","WindowsPC");
                driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumoptions);

            }

        }

        [Test]
        public void OsztasTest()
        {
            var aErtek = driver.FindElementByAccessibilityId("textboxA");
            var bErtek = driver.FindElementByAccessibilityId("textboxB");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            aErtek.Clear();
            bErtek.Clear();
            eredmeny.Clear();
            aErtek.SendKeys("2");
            bErtek.SendKeys("4");
            driver.FindElementByAccessibilityId("buttonSzamol").Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(0.5, Convert.ToDouble(eredmeny.Text));


        }
    }
}