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
        [TestCase(1,2,0.5)]
        [TestCase(2,1,2)]
        [TestCase(15,5,3)]
        [TestCase(35,5,7)]
        [TestCase(56,2,28)]
        public void OsztasTest(double a,double b,double elvart)
        {
            var aErtek = driver.FindElementByAccessibilityId("textboxA");
            var bErtek = driver.FindElementByAccessibilityId("textboxB");
            var eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            aErtek.Clear();
            bErtek.Clear();
            eredmeny.Clear();
            aErtek.SendKeys(a.ToString());
            bErtek.SendKeys(b.ToString());
            driver.FindElementByAccessibilityId("buttonSzamol").Click();
            eredmeny = driver.FindElementByAccessibilityId("textblockEredmeny");
            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text));


        }
    }
}